using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_api.Models;
using backend_api.Dtos.Comment;

namespace backend_api.Mappers
{
    public static class CommentMapper
    {
        public static CommentDto ToCommentDto(this Comment commentModel)
        {
            return new CommentDto
            {
                Id = commentModel.Id,
                Title = commentModel.Title,
                Content = commentModel.Content,
                CreatedOn = commentModel.CreatedOn,
                StockId = commentModel.StockId
            };
        }

        public static Comment ToCommentFromCreateDTO(this CreateCommentDto commentModel)
        {
            return new Comment
            {
                Title = commentModel.Title,
                Content = commentModel.Content
            };
        }
    }
}