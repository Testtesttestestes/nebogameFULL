using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x02001307 RID: 4871
	[Token(Token = "0x2001307")]
	public class SimpleSpriteCloudWorldObjectArgs : SpriteCloudWorldObjectArgs
	{
		// Token: 0x060073DD RID: 29661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073DD")]
		[Address(RVA = "0xBDC0", Offset = "0xBDC0", VA = "0xBDC0")]
		public SimpleSpriteCloudWorldObjectArgs(Vector3 position, Func<float, float, float> randomRange, Sprite sprite, float cloudDistance, float cloudStepDistance)
		{
		/* --- GHIDRA: .ctor ---
		void CloudsFly_SimpleSpriteCloudWorldObjectArgs___ctor
		               (int param1,undefined8 *param2,undefined4 param3,undefined4 param4,float param5,
		               float param6,undefined4 param7)
		
		{
		  *(undefined4 *)(param1 + 0x10) = *(undefined4 *)(param2 + 1);
		  *(undefined8 *)(param1 + 8) = *param2;
		  *(float *)(param1 + 0x20) = param6;
		  *(float *)(param1 + 0x1c) = param5;
		  *(undefined4 *)(param1 + 0x18) = param4;
		  *(undefined4 *)(param1 + 0x14) = param3;
		  return;
		}
		*/

		}
	}
}
