using System;
using Il2CppDummyDll;
using Protocol.ClanIsle;
using Protocol.Consts;

namespace Core.Extensions
{
	// Token: 0x02000F03 RID: 3843
	[Token(Token = "0x2000F03")]
	public static class ClanIsleInformationExt
	{
		// Token: 0x06005D1E RID: 23838 RVA: 0x00010C68 File Offset: 0x0000EE68
		[Token(Token = "0x6005D1E")]
		[Address(RVA = "0xA9A4", Offset = "0xA9A4", VA = "0xA9A4")]
		public static uint GetBuildingLevel(this ProtoGetIsleInfoAns.Types.ClanIsleInformation info, ClanBuildingTypes type)
		{
			return 0U;
		}
	}
}
