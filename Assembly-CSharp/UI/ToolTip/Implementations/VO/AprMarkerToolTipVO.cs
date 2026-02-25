using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace UI.ToolTip.Implementations.VO
{
	// Token: 0x02000161 RID: 353
	[Token(Token = "0x2000161")]
	public class AprMarkerToolTipVO
	{
		// Token: 0x060009F7 RID: 2551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x5D57", Offset = "0x5D57", VA = "0x5D57")]
		public AprMarkerToolTipVO()
		{
		}

		// Token: 0x0400042E RID: 1070
		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x8")]
		public MedalDic Medal;

		// Token: 0x0400042F RID: 1071
		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0xC")]
		public string Title;
	}
}
