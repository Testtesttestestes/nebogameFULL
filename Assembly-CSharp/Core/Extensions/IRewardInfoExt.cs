using System;
using Core.Data.Decorators;
using Il2CppDummyDll;
using Protocol.Common;

namespace Core.Extensions
{
	// Token: 0x02000F0D RID: 3853
	[Token(Token = "0x2000F0D")]
	public static class IRewardInfoExt
	{
		// Token: 0x06005D34 RID: 23860 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D34")]
		[Address(RVA = "0xA9AD", Offset = "0xA9AD", VA = "0xA9AD")]
		public static ResourceSet ExtractResourceSet(this IRewardInfo rewardInfo)
		{
		/* --- GHIDRA: ExtractResourceSet ---
		int Core_Extensions_IRewardInfoExt__ExtractResourceSet
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  
		  param1_00 = UnityEngine_U2D_SpriteAtlas__CanBindTo(param1,param2,0);
		  if (param1_00 == 0) {
		    param1_00 = 0;
		  }
		  else {
		    UnityEngine_Texture2D___ctor(param1_00,param2,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}
	}
}
