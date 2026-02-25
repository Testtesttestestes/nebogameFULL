using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x02001364 RID: 4964
	[Token(Token = "0x2001364")]
	public class TranslationJob_Main : TranslationJob
	{
		// Token: 0x060075D3 RID: 30163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075D3")]
		[Address(RVA = "0xBF5C", Offset = "0xBF5C", VA = "0xBF5C")]
		public TranslationJob_Main(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		// Token: 0x060075D4 RID: 30164 RVA: 0x00015468 File Offset: 0x00013668
		[Token(Token = "0x60075D4")]
		[Address(RVA = "0xBF5D", Offset = "0xBF5D", VA = "0xBF5D", Slot = "5")]
		public override TranslationJob.eJobState GetState()
		{
			return TranslationJob.eJobState.Running;
		}

		// Token: 0x060075D5 RID: 30165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075D5")]
		[Address(RVA = "0xBF5E", Offset = "0xBF5E", VA = "0xBF5E", Slot = "6")]
		public override void Dispose()
		{
		}

		// Token: 0x04003D86 RID: 15750
		[Token(Token = "0x4003D86")]
		[FieldOffset(Offset = "0xC")]
		private TranslationJob_WEB mWeb;

		// Token: 0x04003D87 RID: 15751
		[Token(Token = "0x4003D87")]
		[FieldOffset(Offset = "0x10")]
		private TranslationJob_POST mPost;

		// Token: 0x04003D88 RID: 15752
		[Token(Token = "0x4003D88")]
		[FieldOffset(Offset = "0x14")]
		private TranslationJob_GET mGet;

		// Token: 0x04003D89 RID: 15753
		[Token(Token = "0x4003D89")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, TranslationQuery> _requests;

		// Token: 0x04003D8A RID: 15754
		[Token(Token = "0x4003D8A")]
		[FieldOffset(Offset = "0x1C")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		// Token: 0x04003D8B RID: 15755
		[Token(Token = "0x4003D8B")]
		[FieldOffset(Offset = "0x20")]
		public string mErrorMessage;
	}
}
