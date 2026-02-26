using System;
using Gameplay.Isles.Clan.View;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x020012F4 RID: 4852
	[Token(Token = "0x20012F4")]
	public class ClanIsleWorldObject : BaseIsleWorldObject
	{
		// Token: 0x06007382 RID: 29570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007382")]
		[Address(RVA = "0xBD6E", Offset = "0xBD6E", VA = "0xBD6E", Slot = "12")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void CloudsFly_ClanIsleWorldObject__HandleDataChanged(int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  undefined1 auStack_c [8];
		  float4 local_4;
		  
		  param2_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (*(undefined4 *)(param1 + 0x44),0);
		  func_ii_7888(auStack_c,param2_00,0);
		  if (ABS(-(float)local_4) < 2.1474836e+09) {
		    iVar1 = (int)-(float)local_4;
		  }
		  else {
		    iVar1 = -0x80000000;
		  }
		  *(int *)(param1 + 0x14) = iVar1;
		  CloudsFly_BaseWorldObjectRenderer__GetChildren(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06007383 RID: 29571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007383")]
		[Address(RVA = "0xBD6F", Offset = "0xBD6F", VA = "0xBD6F", Slot = "13")]
		public override void UpdateOrder()
		{
		/* --- GHIDRA: UpdateOrder ---
		void CloudsFly_ClanIsleWorldObject__UpdateOrder(int param1,undefined4 param2)
		
		{
		  *(undefined8 *)(param1 + 0x38) = 0;
		  Gameplay_Isles_Base_View_IsleBossContainer__ValidateBoss(*(undefined4 *)(param1 + 0x30),0);
		  *(undefined4 *)(param1 + 0x40) = 0;
		  Gameplay_Isles_Clan_View_ClanIsleView__Init(*(undefined4 *)(param1 + 0x44),0);
		  Gameplay_Isles_Clan_View_ClanIsleGolemView__Init(*(undefined4 *)(param1 + 0x48),0);
		  Gameplay_Isles_Base_View_IsleBossContainer__ValidateBoss(*(undefined4 *)(param1 + 0x30),0);
		  return;
		}
		*/

		}

		// Token: 0x06007384 RID: 29572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007384")]
		[Address(RVA = "0xBD70", Offset = "0xBD70", VA = "0xBD70", Slot = "14")]
		public override void Reset()
		{
		/* --- GHIDRA: Reset ---
		void CloudsFly_ClanIsleWorldObject__Reset(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59670 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_CloudsFly_WorldObject_IsleCloudObjectArgs___ctor__);
		    DAT_ram_00a59670 = '\x01';
		  }
		  CloudsFly_WorldObjectEngine_object___set_Args
		            (param1,Method_CloudsFly_WorldObject_IsleCloudObjectArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06007385 RID: 29573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007385")]
		[Address(RVA = "0xBD71", Offset = "0xBD71", VA = "0xBD71")]
		public ClanIsleWorldObject()
		{
		/* --- GHIDRA: .ctor ---
		void CloudsFly_ClanIsleWorldObject___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59675 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_CloudsFly_BaseIsleWorldObjectEngine_ClanIsleWorldObjectEngineArgs___ctor__);
		    DAT_ram_00a59675 = '\x01';
		  }
		  Gameplay_Isles_Base_Controller_BaseIsleViewMediator_object__object__object__object___set_View
		            (param1,
		             Method_CloudsFly_BaseIsleWorldObjectEngine_ClanIsleWorldObjectEngineArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x04003C72 RID: 15474
		[Token(Token = "0x4003C72")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private ClanIsleView _isleView;

		// Token: 0x04003C73 RID: 15475
		[Token(Token = "0x4003C73")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ClanIsleGolemView _golemView;
	}
}
