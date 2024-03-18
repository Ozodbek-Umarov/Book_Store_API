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
            throw new CustomExeption(result.Errors);
        }
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<AuthorDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<AuthorDto> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(AuthorDto dto)
    {
        throw new NotImplementedException();
    }
}
