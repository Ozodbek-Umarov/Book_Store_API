using Application.Common;
using Application.DTOs.AuthorDTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using FluentValidation;
using Infrastructures.Inrerfaces;

namespace Application.Services;

public class AuthorService(IUnitOfWork unitOfWork,
                           IMapper mapper,
                           IValidator<Author> validator)
    : IAuthorService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;
    private readonly IValidator<Author> _validator = validator;

    public async Task AddAsync(AddAuthorDto dto)
    {
        if (dto == null)
        {
            throw new CustomExeption("author bosh bolmasin");
        }
        var author = _mapper.Map<Author>(dto);
        var result = await _validator.ValidateAsync(author);
        if (!result.IsValid)
        {
            throw new CustomExeption(result);
        }

        await _unitOfWork.authorInterface.AddAsync(author);
    }

    public async Task DeleteAsync(int id)
    {
        var model = await _unitOfWork.authorInterface.GetByIdAsync(id);
        if (model == null)
        {
            throw new CustomExeption("author topilmadi");
        }
        await _unitOfWork.authorInterface.DeleteAsync(model);
    }

    public async Task<List<AuthorDto>> GetAllAsync()
    {
        var list = await _unitOfWork.authorInterface.GetAllAsync();
        var result = list.Select(_mapper.Map<AuthorDto>)
                        .ToList();
        return result;
    }

    public async Task<AuthorDto> GetByIdAsync(int id)
    {
        var model = await _unitOfWork.authorInterface.GetByIdAsync(id);
        if (model == null)
        {
            throw new CustomExeption("author topilmadi");
        }
        return _mapper.Map<AuthorDto>(model);
    }

    public async Task UpdateAsync(AuthorDto dto)
    {
        var model = await _unitOfWork.authorInterface.GetByIdAsync(dto.Id);
        if (model == null)
        {
            throw new CustomExeption("author topilmadi");
        }
        var author = _mapper.Map<Author>(dto);
        var result = await _validator.ValidateAsync(author);
        if (!result.IsValid)
        {
            throw new CustomExeption("xato");
        }
        await _unitOfWork.authorInterface.UpdateAsync(author);
    }
}
