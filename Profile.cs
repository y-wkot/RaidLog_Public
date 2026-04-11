using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Postgrest.Attributes; // [Table]
using Postgrest.Models; // BaseModel継承

namespace RaidLog
{
    // 対応テーブル
    [Table("profiles")]
    public class Profile : BaseModel // : BaseModel は、Supabase使用時のテンプレ
    {
        // 主キー
        [PrimaryKey("id", false)]
        public string Id { get; set; }

        // 他のカラム
        [Column("user_name")]
        public string UserName { get; set; }
    }
}
