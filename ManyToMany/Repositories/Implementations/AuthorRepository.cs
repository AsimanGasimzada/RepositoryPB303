﻿using ManyToMany.Models;
using ManyToMany.Repositories.Interfaces;

namespace ManyToMany.Repositories.Implementations;

public class AuthorRepository:Repository<Author>,IAuthorRepository
{
}