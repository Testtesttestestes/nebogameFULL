using System;
using Gameplay.Isles.User.View;
using Gameplay.Isles.User.View.Monster;
using Gameplay.Portals.View;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x02001309 RID: 4873
	[Token(Token = "0x2001309")]
	public class UserIsleWorldObject : BaseIsleWorldObject
	{
		// Token: 0x060073DF RID: 29663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073DF")]
		[Address(RVA = "0xBDC2", Offset = "0xBDC2", VA = "0xBDC2", Slot = "12")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void CloudsFly_UserIsleWorldObject__HandleDataChanged(int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  int param2_01;
		  undefined1 auStack_c [8];
		  float4 local_4;
		  
		  param2_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (*(undefined4 *)(param1 + 0x44),0);
		  func_ii_7888(auStack_c,param2_00,0);
		  if (ABS(-(float)local_4) < 2.1474836e+09) {
		    param2_01 = (int)-(float)local_4;
		  }
		  else {
		    param2_01 = -0x80000000;
		  }
		  CloudsFly_BaseWorldObjectRenderer__get_SortingOrder(param1,param2_01,0);
		  return;
		}
		*/

		}

		// Token: 0x060073E0 RID: 29664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073E0")]
		[Address(RVA = "0xBDC3", Offset = "0xBDC3", VA = "0xBDC3", Slot = "13")]
		public override void UpdateOrder()
		{
		/* --- GHIDRA: UpdateOrder ---
		void CloudsFly_UserIsleWorldObject__UpdateOrder(int param1,undefined4 param2)
		
		{
		  CloudsFly_BaseIsleWorldObject__UpdateOrder(param1,0);
		  Gameplay_Isles_User_View_UserIsleView__Init(*(undefined4 *)(param1 + 0x44),0);
		  Gameplay_Isles_User_View_Monster_IsleMonsterView__FadeIn(*(undefined4 *)(param1 + 0x4c),0);
		  Gameplay_Portals_View_PortalsEntryPointView__FadeIn(*(undefined4 *)(param1 + 0x48),0);
		  Gameplay_Isles_Base_View_IsleBossContainer__ValidateBoss(*(undefined4 *)(param1 + 0x30),0);
		  Gameplay_Isles_User_View_BackClanIsleView__Init(*(undefined4 *)(param1 + 0x50),0);
		  Gameplay_Isles_User_View_ColossusOnUserIsleView__Init(*(undefined4 *)(param1 + 0x54),0);
		  return;
		}
		*/

		}

		// Token: 0x060073E1 RID: 29665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073E1")]
		[Address(RVA = "0xBDC4", Offset = "0xBDC4", VA = "0xBDC4", Slot = "14")]
		public override void Reset()
		{
		/* --- GHIDRA: Reset ---
		void CloudsFly_UserIsleWorldObject__Reset(undefined4 param1,undefined4 param2)
		
		{
		  CloudsFly_ClanIsleWorldObject__Reset(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060073E2 RID: 29666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073E2")]
		[Address(RVA = "0xBDC5", Offset = "0xBDC5", VA = "0xBDC5")]
		public UserIsleWorldObject()
		{
		/* --- GHIDRA: .ctor ---
		void CloudsFly_UserIsleWorldObject___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59697 == '\0') {
		    Mono_Security_ASN1__get_Item(&CloudsFly_UserIsleWorldObject___c_TypeInfo);
		    DAT_ram_00a59697 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(CloudsFly_UserIsleWorldObject___c_TypeInfo);
		  **(undefined4 **)(CloudsFly_UserIsleWorldObject___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04003CB1 RID: 15537
		[Token(Token = "0x4003CB1")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private UserIsleView _isleView;

		// Token: 0x04003CB2 RID: 15538
		[Token(Token = "0x4003CB2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private PortalsEntryPointView _portalsEntryPointView;

		// Token: 0x04003CB3 RID: 15539
		[Token(Token = "0x4003CB3")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private IsleMonsterView _monsterView;

		// Token: 0x04003CB4 RID: 15540
		[Token(Token = "0x4003CB4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BackClanIsleView _backClanIsleView;

		// Token: 0x04003CB5 RID: 15541
		[Token(Token = "0x4003CB5")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private ColossusOnUserIsleView _colossusView;
	}
}
