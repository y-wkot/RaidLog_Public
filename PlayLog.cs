using Postgrest.Attributes;
using Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidLog
{

    // 登録・編集　or　削除モードの状態
    public enum ProcMode
    {
        Regist, // 登録・編集モード
        Delete // 削除モード
    }

    // supabaseのplay_logsテーブルと紐づけ
    [Table("play_logs")]
    public class PlayLog : BaseModel
    {
        // カラム定義

        [PrimaryKey("id", false)]
        public string Id { get; set; }

        [Column("user_id")]
        public string Userid { get; set; }

        [Column("play_date")]
        public DateTime PlayDate { get; set; }

        [Column("start_time")]
        public string StartTime { get; set; }

        [Column("end_time")]
        public string EndTime { get; set; }

        [Column("content_name")]
        public string ContentName { get; set; }

        [Column("current_phase")]
        public string CurrentPhase { get; set; }

        [Column("phase_detail")]
        public string PhaseDetail { get; set; }

        [Column("next_phase")]
        public string NextPhase { get; set; }

        [Column("next_phase_detail")]
        public string NextPhaseDetail { get; set; }

        [Column("memo")]
        public string Memo { get; set; }

        [Column("clear_count")]
        public int ClearCount { get; set; }

        [Column("url_youtube")]
        public string UrlYoutube { get; set; }

        [Column("url_fflogs")]
        public string UrlFflogs { get; set; }

        [Column("url_other")]
        public string UrlOther { get; set; }

        [Column("duration_minutes")]
        public int DurationMinutes { get; set; }

        // PTメンバー情報 (ジョブ:名前:備考)
        [Column("member_1")]
        public string Member1 { get; set; }

        [Column("member_2")]
        public string Member2 { get; set; }

        [Column("member_3")]
        public string Member3 { get; set; }

        [Column("member_4")]
        public string Member4 { get; set; }

        [Column("member_5")]
        public string Member5 { get; set; }

        [Column("member_6")]
        public string Member6 { get; set; }

        [Column("member_7")]
        public string Member7 { get; set; }

        [Column("member_8")]
        public string Member8 { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}