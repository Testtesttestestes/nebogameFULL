using System;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Tutorial.Guide
{
	// Token: 0x02001187 RID: 4487
	[Token(Token = "0x2001187")]
	public class TutorialGuideManger : GuideManager
	{
		// Token: 0x170015D5 RID: 5589
		// (get) Token: 0x06006AA9 RID: 27305 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015D5")]
		public new string Name
		{
			[Token(Token = "0x6006AA9")]
			[Address(RVA = "0xB5C2", Offset = "0xB5C2", VA = "0xB5C2")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006AAA RID: 27306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AAA")]
		[Address(RVA = "0xB5C3", Offset = "0xB5C3", VA = "0xB5C3", Slot = "11")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_Tutorial_Guide_TutorialGuideManger__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined4 *)(param1 + 0x10) = 0;
		  iVar1 = *(int *)(param1 + 0xc);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06006AAB RID: 27307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AAB")]
		[Address(RVA = "0xB5C4", Offset = "0xB5C4", VA = "0xB5C4", Slot = "12")]
		public override void Deinit()
		{
		}

		// Token: 0x06006AAC RID: 27308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AAC")]
		[Address(RVA = "0xB5C5", Offset = "0xB5C5", VA = "0xB5C5")]
		public TutorialGuideManger()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Tutorial_Guide_TutorialGuideManger___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a638b1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_Skin__TypeInfo);
		    DAT_ram_00a638b1 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_Skin__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_Skin__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_Tutorial_Guide_TutorialGuideManger__get_Name
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a638b0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Control_GuideController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_GuideModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Tutorial_ITutorialManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_User_UserSettingsStub_TypeInfo);
		    DAT_ram_00a638b0 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x1a0);
		        goto code_r0x8230dc54;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x1c);
		code_r0x8230dc54:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar1 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Tutorial_ITutorialManager_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8230dcd6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_Managers_Tutorial_ITutorialManager_TypeInfo,3);
		code_r0x8230dcd6:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  param1_00 = unnamed_function_1417(Core_Data_User_UserSettingsStub_TypeInfo);
		  Core_Data_User_UserSettingsStub__CommitSettings(param1_00,0);
		  param1_01 = unnamed_function_1417(Gameplay_Tutorial_Guide_Model_GuideModel_TypeInfo);
		  Gameplay_Tutorial_Guide_Model_GuideModel__Dispose(param1_01,uVar3,0,0,param1_00,0);
		  uVar3 = unnamed_function_1417(Gameplay_Tutorial_Guide_Control_GuideController_TypeInfo);
		  Gameplay_Tutorial_Guide_Control_GuideController__Dispose(uVar3,param1_01,0,0);
		  *(undefined4 *)(param1 + 0x10) = uVar3;
		  iVar5 = *(int *)(param1 + 8);
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		            (*(undefined4 *)(iVar5 + 0x20),param1,*(undefined4 *)(iVar5 + 0x14));
		  return;
		}
		*/

}
