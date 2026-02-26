using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Utils
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	[ExecuteInEditMode]
	public abstract class BaseMonoBehaviour : MonoBehaviour
	{
		// Token: 0x06000228 RID: 552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x56CE", Offset = "0x56CE", VA = "0x56CE", Slot = "4")]
		protected virtual void OnValidateSafety()
		{
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x56CF", Offset = "0x56CF", VA = "0x56CF")]
		protected BaseMonoBehaviour()
		{
		/* --- GHIDRA: .ctor ---
		void Utils_BaseMonoBehaviour___ctor(undefined1 *param1,int param2,undefined4 param3)
		
		{
		  param1[3] = 0xff;
		  *param1 = (char)((uint)param2 >> 0x10);
		  *(ushort *)(param1 + 1) = (ushort)(param2 << 8) | (ushort)((uint)param2 >> 8) & 0xff;
		  return;
		}
		*/

		}
	}
}
