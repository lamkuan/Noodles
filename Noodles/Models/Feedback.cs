using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Noodles.Models;

public class Feedback
{
    [BindNever]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "請留下你的名字")]
    [StringLength(50, ErrorMessage = "名字不能超過20個字")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "請填寫你的Email")]
    [StringLength(50, ErrorMessage = "email不能超過50個字符")]
    [DataType(DataType.EmailAddress, ErrorMessage = "請填寫正確的Email格式")]
    [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
        ErrorMessage = "请填写正确的email格式")]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "請留下你的反饋意見")]
    [StringLength(400, ErrorMessage = "反饋意見不能超過200個字")]
    public string Message { get; set; }
    
    public DateTime CreateDateUTC { get; set; }
}