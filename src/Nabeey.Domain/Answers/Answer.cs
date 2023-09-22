﻿using Nabeey.Domain.Assets;
using Nabeey.Domain.Commons;
using Nabeey.Domain.QuestionAnswers;

namespace Nabeey.Domain.Answers;

public class Answer:Auditable
{
    public long AssetId { get; set; }
    public Asset Asset { get; set; }
    public string Text { get; set; }
    public ICollection<QuestionAnswer> QuestionAnswers { get; set; }
}
