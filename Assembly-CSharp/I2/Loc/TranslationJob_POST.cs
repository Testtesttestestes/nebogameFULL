using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x02001365 RID: 4965
	[Token(Token = "0x2001365")]
	public class TranslationJob_POST : TranslationJob_WWW
	{
		// Token: 0x060075D6 RID: 30166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075D6")]
		[Address(RVA = "0xBF5F", Offset = "0xBF5F", VA = "0xBF5F")]
		public TranslationJob_POST(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		// Token: 0x060075D7 RID: 30167 RVA: 0x00015480 File Offset: 0x00013680
		[Token(Token = "0x60075D7")]
		[Address(RVA = "0xBF60", Offset = "0xBF60", VA = "0xBF60", Slot = "5")]
		public override TranslationJob.eJobState GetState()
		{
			return TranslationJob.eJobState.Running;
		}

		// Token: 0x060075D8 RID: 30168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075D8")]
		[Address(RVA = "0xBF61", Offset = "0xBF61", VA = "0xBF61")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		}

		// Token: 0x04003D8C RID: 15756
		[Token(Token = "0x4003D8C")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, TranslationQuery> _requests;

		// Token: 0x04003D8D RID: 15757
		[Token(Token = "0x4003D8D")]
		[FieldOffset(Offset = "0x14")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;
	}
}
