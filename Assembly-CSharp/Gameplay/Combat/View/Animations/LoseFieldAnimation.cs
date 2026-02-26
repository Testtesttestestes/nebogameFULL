using System;
using System.Collections;
using Gameplay.Combat.View.GameField;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Combat.View.Animations
{
	// Token: 0x02000985 RID: 2437
	[Token(Token = "0x2000985")]
	[Serializable]
	public class LoseFieldAnimation : IDisposable
	{
		// Token: 0x06003A29 RID: 14889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A29")]
		[Address(RVA = "0x89A5", Offset = "0x89A5", VA = "0x89A5")]
		public void StartAnimation(StoneMono[,] stones, Transform parent)
		{
		/* --- GHIDRA: StartAnimation ---
		int Gameplay_Combat_View_Animations_LoseFieldAnimation__StartAnimation
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57e21 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_Animations_LoseFieldAnimation__LoseEffect_d__2_TypeInfo);
		    DAT_ram_00a57e21 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Combat_View_Animations_LoseFieldAnimation__LoseEffect_d__2_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param2;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06003A2A RID: 14890 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003A2A")]
		[Address(RVA = "0x89A6", Offset = "0x89A6", VA = "0x89A6")]
		private IEnumerator LoseEffect(StoneMono[,] stones)
		{
		/* --- GHIDRA: LoseEffect ---
		void Gameplay_Combat_View_Animations_LoseFieldAnimation__LoseEffect(int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 8) != 0) {
		    func_ii_7950(*(int *)(param1 + 8),0);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003A2B RID: 14891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A2B")]
		[Address(RVA = "0x89A7", Offset = "0x89A7", VA = "0x89A7", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06003A2C RID: 14892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A2C")]
		[Address(RVA = "0x89A8", Offset = "0x89A8", VA = "0x89A8")]
		public LoseFieldAnimation()
		{
		}

		// Token: 0x0400201A RID: 8218
		[Token(Token = "0x400201A")]
		[FieldOffset(Offset = "0x8")]
		private Coroutine _routine;
	}
}
