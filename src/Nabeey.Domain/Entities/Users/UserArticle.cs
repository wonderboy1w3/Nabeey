﻿using Nabeey.Domain.Commons;

namespace Nabeey.Domain.Entities.Users;

public class UserArticle : Auditable
{
    public long UserId { get; set; }
    public User User { get; set; }
    public long ArticleId { get; set; }
    public Article Article { get; set; }
}