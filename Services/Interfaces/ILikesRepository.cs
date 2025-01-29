using DateApi.DTOs;
using DateApi.Entities;
using DateApi.Helpers;

namespace DateApi.Services.Interfaces;

public interface ILikesRepository
{
    Task<UserLike?> GetUserLike(int sourceUserId, int targetUserId);

    Task<PagedList<MemberDto>> GetUserLikes(LikesParams likesParams);

    Task<IEnumerable<int>> GetCurrentUserLikeIds(int currentUserId);

    void DeleteLike(UserLike like);

    void AddLike(UserLike like);
}
