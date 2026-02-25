using System;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Configuration
{
	// Token: 0x02001233 RID: 4659
	[Token(Token = "0x2001233")]
	[Serializable]
	public class LaunchAppVars
	{
		// Token: 0x06006E53 RID: 28243 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006E53")]
		[Address(RVA = "0xB8F6", Offset = "0xB8F6", VA = "0xB8F6")]
		public LaunchAppVars Clone()
		{
			return null;
		}

		// Token: 0x06006E54 RID: 28244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E54")]
		[Address(RVA = "0xB8F7", Offset = "0xB8F7", VA = "0xB8F7")]
		public LaunchAppVars()
		{
		}

		// Token: 0x040039B3 RID: 14771
		[Token(Token = "0x40039B3")]
		[FieldOffset(Offset = "0x8")]
		public string email;

		// Token: 0x040039B4 RID: 14772
		[Token(Token = "0x40039B4")]
		[FieldOffset(Offset = "0xC")]
		public bool email_activated;

		// Token: 0x040039B5 RID: 14773
		[Token(Token = "0x40039B5")]
		[FieldOffset(Offset = "0x10")]
		public string html_canvas_id;

		// Token: 0x040039B6 RID: 14774
		[Token(Token = "0x40039B6")]
		[FieldOffset(Offset = "0x14")]
		public bool show_tutorial;

		// Token: 0x040039B7 RID: 14775
		[Token(Token = "0x40039B7")]
		[FieldOffset(Offset = "0x18")]
		public string currency_converter_path;

		// Token: 0x040039B8 RID: 14776
		[Token(Token = "0x40039B8")]
		[FieldOffset(Offset = "0x1C")]
		public string curator_uri;

		// Token: 0x040039B9 RID: 14777
		[Token(Token = "0x40039B9")]
		[FieldOffset(Offset = "0x20")]
		public string feedback_form_uri;

		// Token: 0x040039BA RID: 14778
		[Token(Token = "0x40039BA")]
		[FieldOffset(Offset = "0x24")]
		public string hv_services_auth_token;

		// Token: 0x040039BB RID: 14779
		[Token(Token = "0x40039BB")]
		[FieldOffset(Offset = "0x28")]
		public string client_id;

		// Token: 0x040039BC RID: 14780
		[Token(Token = "0x40039BC")]
		[FieldOffset(Offset = "0x2C")]
		public string okg_analytics_uri;

		// Token: 0x040039BD RID: 14781
		[Token(Token = "0x40039BD")]
		[FieldOffset(Offset = "0x30")]
		public string marketing_params;

		// Token: 0x040039BE RID: 14782
		[Token(Token = "0x40039BE")]
		[FieldOffset(Offset = "0x34")]
		public string locale;
	}
}
