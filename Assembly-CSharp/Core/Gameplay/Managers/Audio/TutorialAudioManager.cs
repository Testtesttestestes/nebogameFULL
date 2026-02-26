using System;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Audio
{
	// Token: 0x020011F7 RID: 4599
	[Token(Token = "0x20011F7")]
	public class TutorialAudioManager : AudioManager
	{
		// Token: 0x17001639 RID: 5689
		// (get) Token: 0x06006D3F RID: 27967 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001639")]
		public new string Name
		{
			[Token(Token = "0x6006D3F")]
			[Address(RVA = "0xB827", Offset = "0xB827", VA = "0xB827")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006D40 RID: 27968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D40")]
		[Address(RVA = "0xB828", Offset = "0xB828", VA = "0xB828")]
		public TutorialAudioManager(IGame game)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Audio_TutorialAudioManager___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  int param3;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 param5;
		  undefined4 param1_00;
		  int *piVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a5a75d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_Audio_AudioClipCache_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Sound_Control_AudioController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Sound_AudioEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_Audio_AudioManager_HandleInitEvent__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Sound_Model_AudioModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Sound_Control_AudioSourceMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Tutorial_ITutorialManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_User_UserSettingsStub_TypeInfo);
		    DAT_ram_00a5a75d = '\x01';
		  }
		  iVar2 = unnamed_function_1417(Core_Data_User_UserSettingsStub_TypeInfo);
		  Core_Data_User_UserSettingsStub__CommitSettings(iVar2,0);
		  *(undefined2 *)(*(int *)(iVar2 + 8) + 8) = 0x101;
		  param3 = unnamed_function_1417(Gameplay_Sound_AudioEvents_TypeInfo);
		  uVar3 = unnamed_function_1417(Core_Cache_Audio_AudioClipCache_TypeInfo);
		  Core_Cache_Clan_ClanCache___c___Update_b__3_0(uVar3,3.4028235e+38,0);
		  piVar6 = *(int **)(param1 + 0x10);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x81267599;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81267599:
		  uVar1 = 0;
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x10);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x1a0);
		        goto code_r0x8126761e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x1c);
		code_r0x8126761e:
		  piVar6 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar1 = 0;
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Tutorial_ITutorialManager_TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd8);
		        goto code_r0x812676a0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_Managers_Tutorial_ITutorialManager_TypeInfo,3);
		code_r0x812676a0:
		  param5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  param1_00 = unnamed_function_1417(Gameplay_Sound_Model_AudioModel_TypeInfo);
		  Gameplay_Sound_Model_AudioModel__Dispose(param1_00,iVar2,uVar3,uVar5,param5,0);
		  uVar5 = *(undefined4 *)(param3 + 8);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,Method_Core_Gameplay_Managers_Audio_AudioManager_HandleInitEvent__,0);
		  piVar6 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		  iVar2 = System_Action_TypeInfo;
		  if (piVar6 == (int *)0x0) {
		    *(undefined4 *)(param3 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar6) || (*(int **)(param3 + 8) = piVar6, *piVar6 != iVar2)
		          ) {
		    System_Activator__CreateInstance(piVar6,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar3 = unnamed_function_1417(Gameplay_Sound_Control_AudioController_TypeInfo);
		  Gameplay_Sound_Control_AudioController__set__detectCoroutine(uVar3,param1_00,param3,0);
		  *(undefined4 *)(param1 + 0x18) = uVar3;
		  piVar6 = (int *)unnamed_function_1417(Gameplay_Sound_Control_AudioSourceMediator_TypeInfo);
		  Gameplay_Sound_Control_AudioSourceMediator___c__DisplayClass6_0___HandleStopMusicEvent_b__0
		            (piVar6,param1_00,param3,uVar3,0);
		  *(int **)(param1 + 0x14) = piVar6;
		  iVar2 = System_Uri___ctor(0);
		  (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x160) * 4))
		            (piVar6,*(undefined4 *)(*(int *)(iVar2 + 0x18) + 0x30),*(undefined4 *)(*piVar6 + 0x164))
		  ;
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x18),0);
		  return;
		}
		*/

		}

		// Token: 0x06006D41 RID: 27969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D41")]
		[Address(RVA = "0xB829", Offset = "0xB829", VA = "0xB829", Slot = "11")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_Audio_TutorialAudioManager__Init
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a75e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_AdTransaction__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_Ad_Statistics_AdStatisticsHelper_AdRewardedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Statistics_AdStatisticsHelper_TransactionClosedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Statistics_AdStatisticsHelper_TransactionCreatedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__AdTransactionStatisticsInfo___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_string__AdTransactionStatisticsInfo__TypeInfo)
		    ;
		    DAT_ram_00a5a75e = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_string__AdTransactionStatisticsInfo__TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar1,
		             Method_System_Collections_Generic_Dictionary_string__AdTransactionStatisticsInfo___ctor__
		            );
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  *(int *)(param1 + 8) = param2;
		  iVar5 = *(int *)(param2 + 0x18);
		  *(int *)(param1 + 0xc) = iVar5;
		  uVar4 = *(undefined4 *)(iVar5 + 0x1c);
		  uVar1 = unnamed_function_1417(System_Action_AdTransaction__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Core_Gameplay_Managers_Ad_Statistics_AdStatisticsHelper_TransactionCreatedEvent__
		             ,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar4,uVar1,0);
		  uVar1 = System_Action_AdTransaction__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar5 + 0x1c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_AdTransaction__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar5 + 0x1c) = iVar3;
		    uVar1 = System_Action_AdTransaction__TypeInfo;
		    iVar5 = func_ii_1082(iVar2,System_Action_AdTransaction__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar5 = *(int *)(param1 + 0xc);
		  uVar4 = *(undefined4 *)(iVar5 + 0x20);
		  uVar1 = unnamed_function_1417(System_Action_string__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Core_Gameplay_Managers_Ad_Statistics_AdStatisticsHelper_TransactionClosedEvent__
		             ,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar4,uVar1,0);
		  uVar1 = System_Action_string__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar5 + 0x20) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_string__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar5 + 0x20) = iVar3;
		    uVar1 = System_Action_string__TypeInfo;
		    iVar5 = func_ii_1082(iVar2,System_Action_string__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar5 = *(int *)(param1 + 0xc);
		  uVar4 = *(undefined4 *)(iVar5 + 0x14);
		  uVar1 = unnamed_function_1417(System_Action_AdTransaction__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Core_Gameplay_Managers_Ad_Statistics_AdStatisticsHelper_AdRewardedEvent__,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar4,uVar1,0);
		  uVar1 = System_Action_AdTransaction__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar5 + 0x14) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar2,System_Action_AdTransaction__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar5 + 0x14) = iVar3;
		    uVar1 = System_Action_AdTransaction__TypeInfo;
		    iVar5 = func_ii_1082(iVar2,System_Action_AdTransaction__TypeInfo);
		    if (iVar5 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar2,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar2,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}
	}
}
