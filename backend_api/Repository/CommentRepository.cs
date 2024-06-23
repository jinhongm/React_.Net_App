using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_api.Data;
using backend_api.Models;
using backend_api.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace backend_api.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDBContext _context;
        public CommentRepository(ApplicationDBContext context){
            _context = context;
        }

        public async Task<List<Comment>> GetAllAsync()
        {
            return await _context.Comments.ToListAsync();
        }

        public async Task<Comment> GetByIdAsync(int id){
            return await _context.Comments.FindAsync(id);
        }

        public async Task<Comment> CreateAsync(Comment commentDto)
        {
            await _context.Comments.AddAsync(commentDto);
            await _context.SaveChangesAsync();
            return commentDto;
        }

    }
}