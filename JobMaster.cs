using Postgrest.Attributes;
using Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidLog
{
    // supabaseのジョブ管理テーブルjob_mastersと紐づける
    [Table("job_masters")]
    public class JobMaster : BaseModel
    {
        [PrimaryKey("id", false)]
        public int Id { get; set; }

        [Column("job_name")]
        public string jobName { get; set; } // ジョブ名称

        [Column("role_name")]
        public string RoleName { get; set; } // ロール名称（Tank, Healer等）

        [Column("display_order")]
        public int DisplayOrder { get; set; } // 並び順
    }
}
