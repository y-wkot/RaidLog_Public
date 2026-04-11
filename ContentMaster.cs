using Postgrest.Attributes;
using Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidLog
{
    // supabaseテーブルcontent_mastersと紐づけ
    [Table("content_masters")]
    public class ContentMaster: BaseModel
    {
        [PrimaryKey("id", false)]
        public int Id { get; set; }

        [Column("content_name")]
        public string ContentName { get; set; } // コンテンツ名称

        [Column("phase_name")]
        public string PhaseName { get; set; } // フェーズ名称（例：P1,P2）

        [Column("detail_gimmick")]
        public string DetailGimmick { get; set; } // ギミック詳細（例：聖杖,死刻,ハローワールド）

        [Column("display_order")]
        public int DisplayOrder { get; set; } // 並び順

        [Column("content_order")]
        public int ContentOrder { get; set; } // コンテンツ名の並び順用　今はDB直接いじるしかない
    }
}
