﻿namespace ManyToMany.DTOs.BookDtos;

public class BookPutDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public int StockCount { get; set; }
    public int AuthorId { get; set; }
}