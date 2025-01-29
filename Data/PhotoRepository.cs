﻿using DateApi.DTOs;
using DateApi.Entities;
using DateApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DateApi.Data;

public class PhotoRepository(DateAppDbContext context) : IPhotoRepository
{
    public async Task<Photo?> GetPhotoById(int id)
    { return await context.Photos.IgnoreQueryFilters().SingleOrDefaultAsync(x => x.Id == id); }

    public async Task<IEnumerable<PhotoForApprovalDto>> GetUnapprovedPhotos()
    {
        return await context.Photos
            .IgnoreQueryFilters()
            .Where(p => p.IsApproved == false)
            .Select(
                u => new PhotoForApprovalDto
                {
                    Id = u.Id,
                    Username = u.AppUser.UserName,
                    Url = u.Url,
                    IsApproved = u.IsApproved
                })
            .ToListAsync();
    }

    public void RemovePhoto(Photo photo) { context.Photos.Remove(photo); }
}
