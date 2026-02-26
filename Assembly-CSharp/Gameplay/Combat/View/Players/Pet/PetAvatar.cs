using System;
using Il2CppDummyDll;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.Combat.View.Players.Pet
{
	// Token: 0x02000956 RID: 2390
	[Token(Token = "0x2000956")]
	public class PetAvatar : MonoBehaviour, IToolTipDataProvider
	{
		// Token: 0x060038B0 RID: 14512 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60038B0")]
		[Address(RVA = "0x884E", Offset = "0x884E", VA = "0x884E", Slot = "4")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x060038B1 RID: 14513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038B1")]
		[Address(RVA = "0x884F", Offset = "0x884F", VA = "0x884F")]
		public PetAvatar()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_Players_Pet_PetAvatar___ctor(int param1,undefined4 param2)
		
		{
		  float param2_00;
		  
		  param2_00 = 1.0;
		  if (*(char *)(param1 + 0x1c) == '\0') {
		    param2_00 = 0.0;
		  }
		  AssetContent_Loaders_GameSpriteRendererLoader__HandleSpriteChanged
		            (*(undefined4 *)(param1 + 0x24),param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x04001F4E RID: 8014
		[Token(Token = "0x4001F4E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _pet;
	}
}
