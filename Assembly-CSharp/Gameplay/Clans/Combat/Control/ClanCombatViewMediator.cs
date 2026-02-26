using System;
using System.Collections.Generic;
using Gameplay.Clans.Combat.Model;
using Gameplay.Clans.Combat.View;
using Gameplay.Combat.Control;
using Gameplay.Combat.Model;
using Gameplay.Combat.View;
using Il2CppDummyDll;

namespace Gameplay.Clans.Combat.Control
{
	// Token: 0x02000AA4 RID: 2724
	[Token(Token = "0x2000AA4")]
	public class ClanCombatViewMediator : AbstractCombatViewMediator<ClanCombatModel, ClanCombatEvents, ClanCombatController, ClanCombatView>
	{
		// Token: 0x06004195 RID: 16789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004195")]
		[Address(RVA = "0x904C", Offset = "0x904C", VA = "0x904C")]
		public ClanCombatViewMediator(ClanCombatModel model, ClanCombatEvents events, ClanCombatController controller)
		{
		/* --- GHIDRA: <HandleGameOver>b__6_0 ---
		undefined4
		Gameplay_Clans_Combat_Control_ClanCombatViewMediator___HandleGameOver_b__6_0
		          (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                    (*(undefined4 *)(param1 + 0xc),0);
		  return uVar1;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Combat_Control_ClanCombatViewMediator___ctor(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a577b0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatView__HandleSetupView__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandleExitFromViewMoveClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandleStartCombatClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a577b0 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = *(int *)(iVar2 + 0x4c);
		  uVar5 = *(undefined4 *)(*(int *)(param1[2] + 0x3c) + 0x1c);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x80ddb0b2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ddb0b2:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		  *(undefined4 *)(iVar2 + 0xa4) = uVar4;
		  *(undefined4 *)(iVar2 + 0xa0) = uVar5;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = *(int *)(iVar2 + 0x50);
		  uVar5 = *(undefined4 *)(*(int *)(param1[2] + 0x3c) + 0x1c);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x80ddb198;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ddb198:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		  *(undefined4 *)(iVar2 + 0xa4) = uVar4;
		  *(undefined4 *)(iVar2 + 0xa0) = uVar5;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(*(int *)(iVar2 + 0x68) + 0xb4);
		  uVar5 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar5,param1,
		             Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandleStartCombatClickEvent__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar4,uVar5,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(*(int *)(iVar2 + 0x6c) + 0xb4);
		  uVar5 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar5,param1,
		             Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandleExitFromViewMoveClickEvent__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar4,uVar5,0);
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___HandleSelectedSpellChangedEvent
		            (param1,
		             Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatView__HandleSetupView__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004196 RID: 16790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004196")]
		[Address(RVA = "0x904D", Offset = "0x904D", VA = "0x904D", Slot = "31")]
		protected override void HandleSetupView()
		{
		/* --- GHIDRA: HandleSetupView ---
		void Gameplay_Clans_Combat_Control_ClanCombatViewMediator__HandleSetupView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a577b1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatView__HandleResetView__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandleExitFromViewMoveClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandleStartCombatClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a577b1 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x68) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandleStartCombatClickEvent__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x6c) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandleExitFromViewMoveClickEvent__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___HandleRequestViewEvent
		            (param1,
		             Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatView__HandleResetView__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004197 RID: 16791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004197")]
		[Address(RVA = "0x904E", Offset = "0x904E", VA = "0x904E", Slot = "32")]
		protected override void HandleResetView()
		{
		/* --- GHIDRA: HandleResetView ---
		void Gameplay_Clans_Combat_Control_ClanCombatViewMediator__HandleResetView
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  float fVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  int *piVar9;
		  int local_20;
		  undefined8 *puStack_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a577b2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatView__DefineStonesSkins__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_CombatPlayer__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_CombatPlayer__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_CombatPlayer__get_Current__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Spells_ICombatSpellDisplay_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Sound_Control_IGameAudio_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_User_IUserSettings_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CombatPlayer__GetEnumerator__);
		    DAT_ram_00a577b2 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___CloseAwaitCombatWindow
		            (param1,
		             Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatView__DefineStonesSkins__
		            );
		  piVar7 = *(int **)(*(int *)(param1[2] + 0x3c) + 0x1c);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Sound_Control_IGameAudio_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 200);
		        goto code_r0x80ddb42e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Gameplay_Sound_Control_IGameAudio_TypeInfo,1);
		code_r0x80ddb42e:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar7,0xc,puVar2[1]);
		  piVar7 = (int *)param1[2];
		  piVar9 = *(int **)(piVar7[0xf] + 0x1c);
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar7 + 0x118) * 4))
		                    (piVar7,*(undefined4 *)(*piVar7 + 0x11c));
		  iVar8 = *piVar9;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Sound_Control_IGameAudio_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80ddb4d9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar9,Gameplay_Sound_Control_IGameAudio_TypeInfo,0);
		code_r0x80ddb4d9:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar9,uVar3,puVar2[1]);
		  iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar7 = *(int **)(iVar8 + 0x1c);
		  iVar8 = *(int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(iVar8 + 0xf0) * 4))
		                    ((int *)param1[2],*(undefined4 *)(iVar8 + 0xf4));
		  uVar1 = 0;
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Combat_View_Spells_ICombatSpellDisplay_TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 200);
		        goto code_r0x80ddb58f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Gameplay_Combat_View_Spells_ICombatSpellDisplay_TypeInfo,1);
		code_r0x80ddb58f:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar7,uVar3,puVar2[1]);
		  iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar7 = *(int **)(iVar8 + 0x48);
		  iVar8 = *(int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(iVar8 + 0xf8) * 4))
		                    ((int *)param1[2],*(undefined4 *)(iVar8 + 0xfc));
		  uVar1 = 0;
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Combat_View_Spells_ICombatSpellDisplay_TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 200);
		        goto code_r0x80ddb645;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Gameplay_Combat_View_Spells_ICombatSpellDisplay_TypeInfo,1);
		code_r0x80ddb645:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar7,uVar3,puVar2[1]);
		  iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = 0;
		  piVar7 = *(int **)(iVar8 + 0x1c);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Combat_View_Spells_ICombatSpellDisplay_TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xd0);
		        goto code_r0x80ddb6dc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Gameplay_Combat_View_Spells_ICombatSpellDisplay_TypeInfo,2);
		code_r0x80ddb6dc:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		  iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = 0;
		  piVar7 = *(int **)(iVar8 + 0x48);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Combat_View_Spells_ICombatSpellDisplay_TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xd0);
		        goto code_r0x80ddb778;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Gameplay_Combat_View_Spells_ICombatSpellDisplay_TypeInfo,2);
		code_r0x80ddb778:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		  iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar7 = *(int **)(iVar8 + 0x14);
		  uVar1 = 0;
		  uVar3 = *(undefined4 *)(param1[2] + 0x2c);
		  piVar9 = *(int **)(*(int *)(param1[2] + 0x3c) + 0x20);
		  iVar8 = *piVar9;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Data_User_IUserSettings_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80ddb826;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar9,Core_Data_User_IUserSettings_TypeInfo,0);
		code_r0x80ddb826:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar9,puVar2[1]);
		  fVar5 = Gameplay_Combat_Model_GameFieldGamesData__GetAnimationTimeByFieldChangeType
		                    (*(undefined4 *)(param1[2] + 0x2c),0xc,0);
		  iVar8 = *piVar7;
		  (**(code **)((ulonglong)*(uint *)(iVar8 + 0xf0) * 4))
		            (piVar7,uVar3,uVar4,fVar5,*(undefined4 *)(iVar8 + 0xf4));
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x1a8) * 4))(param1,*(undefined4 *)(*param1 + 0x1ac));
		  Gameplay_Clans_Combat_Control_ClanCombatViewMediator__SetSpellElixirs(param1,&local_20);
		  iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_RightPanel_TitleWithLevel__set_Level
		            (*(undefined4 *)(iVar8 + 100),*(undefined4 *)(param1[2] + 0x7c),0);
		  piVar7 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar7 + 0x148) * 4))
		                    (piVar7,*(undefined4 *)(piVar7[3] + 0x2c),*(undefined4 *)(*piVar7 + 0x14c));
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,uVar3,Method_System_Collections_Generic_List_CombatPlayer__GetEnumerator__);
		  local_8 = local_18;
		  local_10 = CONCAT44(puStack_1c,local_20);
		  local_20 = 0;
		  puStack_1c = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_CombatPlayer__MoveNext__);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ddb9a3;
		    }
		    if (iVar6 == 0) goto code_r0x80ddb9f9;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x359,param1,local_8._4_4_,
		               &local_20);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar8 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ddb9a3:
		  iVar8 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar6) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar6 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar6;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) {
		      if (iVar6 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80ddb9f9:
		      DAT_ram_009d3e38 = 0;
		      piVar7 = (int *)param1[2];
		      uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar7 + 0x150) * 4))
		                        (piVar7,*(undefined4 *)(piVar7[3] + 0x2c),*(undefined4 *)(*piVar7 + 0x154));
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_20,uVar3,
		                 Method_System_Collections_Generic_List_CombatPlayer__GetEnumerator__);
		      local_8 = local_18;
		      local_10 = CONCAT44(puStack_1c,local_20);
		      local_20 = 0;
		      puStack_1c = &local_10;
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar6 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                           Method_System_Collections_Generic_List_Enumerator_CombatPlayer__MoveNext__
		                          );
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80ddbb26;
		        }
		        if (iVar6 == 0) goto code_r0x80ddbb7c;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x359,param1,local_8._4_4_,
		                   &local_20);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar8 != 1);
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ddbb26:
		      iVar8 = global_1;
		      iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar8 == iVar6) {
		        piVar7 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar6 = *piVar7;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar6;
		        import::env::invoke_v(0x123);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 != 1) {
		          if (iVar6 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x80ddbb7c:
		          DAT_ram_009d3e38 = 0;
		          Gameplay_Clans_Combat_Control_ClanCombatViewMediator__HandlePlayersMovedEvent
		                    (param1,&local_20);
		          piVar7 = (int *)param1[2];
		          if ((char)piVar7[0x19] == '\0') {
		            uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar7 + 0x100) * 4))
		                              (piVar7,*(undefined4 *)(*piVar7 + 0x104));
		            Gameplay_Clans_Combat_Control_ClanCombatViewMediator__ShowCurrentPlayersInfo
		                      (param1,uVar3,&local_20);
		          }
		          return;
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x35b,&local_20);
		      goto joined_r0x80ddbbe9;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x35a,&local_20);
		joined_r0x80ddbbe9:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004198 RID: 16792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004198")]
		[Address(RVA = "0x904F", Offset = "0x904F", VA = "0x904F", Slot = "23")]
		protected override void HandleInitEvent()
		{
		/* --- GHIDRA: HandleInitEvent ---
		void Gameplay_Clans_Combat_Control_ClanCombatViewMediator__HandleInitEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int *param1_00;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a577b3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatView__AddGameProcessEventsHandlers__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_CombatPlayer__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_List_CombatPlayer___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IList_CombatPlayer___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_CombatPlayer__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandleChatEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandleEffectsChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandleJointEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandlePlayerAddedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandlePlayerRemovedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandlePlayersMovedEvent__
		              );
		    DAT_ram_00a577b3 = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object____TryRunStoneDestroyVfx_g__Run_30_0
		            (param1,
		             Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatView__AddGameProcessEventsHandlers__
		            );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar1 + 0x70);
		  uVar2 = unnamed_function_1417(System_Action_List_CombatPlayer___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandlePlayersMovedEvent__,0
		            );
		  iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_List_CombatPlayer___TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(iVar1 + 0x70) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar3,System_Action_List_CombatPlayer___TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x70) = iVar4;
		    uVar2 = System_Action_List_CombatPlayer___TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_List_CombatPlayer___TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar1 + 0x30);
		  uVar2 = unnamed_function_1417(System_Action_CombatPlayer__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandlePlayerAddedEvent__,0)
		  ;
		  iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_CombatPlayer__TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(iVar1 + 0x30) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar3,System_Action_CombatPlayer__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x30) = iVar4;
		    uVar2 = System_Action_CombatPlayer__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_CombatPlayer__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar1 + 0x34);
		  uVar2 = unnamed_function_1417(System_Action_CombatPlayer__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandlePlayerRemovedEvent__,
		             0);
		  iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_CombatPlayer__TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(iVar1 + 0x34) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar3,System_Action_CombatPlayer__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x34) = iVar4;
		    uVar2 = System_Action_CombatPlayer__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_CombatPlayer__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar1 + 0x60);
		  uVar2 = unnamed_function_1417(System_Action_IList_CombatPlayer___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandleEffectsChangedEvent__
		             ,0);
		  iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_IList_CombatPlayer___TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(iVar1 + 0x60) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar3,System_Action_IList_CombatPlayer___TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x60) = iVar4;
		    uVar2 = System_Action_IList_CombatPlayer___TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_IList_CombatPlayer___TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar1 + 0x6c);
		  uVar2 = unnamed_function_1417(System_Action_CombatPlayer__string__TypeInfo);
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		            (uVar2,param1,
		             Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandleChatEvent__,0);
		  iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_CombatPlayer__string__TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(iVar1 + 0x6c) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar3,System_Action_CombatPlayer__string__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x6c) = iVar4;
		    uVar2 = System_Action_CombatPlayer__string__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_CombatPlayer__string__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar3 + 0x74);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandleJointEvent__,0);
		  param1_00 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(iVar3 + 0x74) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *param1_00) &&
		     (*(int **)(iVar3 + 0x74) = param1_00, *param1_00 == iVar1)) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_00,iVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004199 RID: 16793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004199")]
		[Address(RVA = "0x9050", Offset = "0x9050", VA = "0x9050", Slot = "29")]
		protected override void AddGameProcessEventsHandlers()
		{
		/* --- GHIDRA: AddGameProcessEventsHandlers ---
		void Gameplay_Clans_Combat_Control_ClanCombatViewMediator__AddGameProcessEventsHandlers
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int *param1_00;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a577b4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatView__RemoveGameProcessEventsHandlers__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_CombatPlayer__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_List_CombatPlayer___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IList_CombatPlayer___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_CombatPlayer__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandleChatEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandleEffectsChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandleJointEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandlePlayerAddedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandlePlayerRemovedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandlePlayersMovedEvent__
		              );
		    DAT_ram_00a577b4 = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___HandleUserSkillsChangedEvent
		            (param1,
		             Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatView__RemoveGameProcessEventsHandlers__
		            );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar1 + 0x70);
		  uVar2 = unnamed_function_1417(System_Action_List_CombatPlayer___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandlePlayersMovedEvent__,0
		            );
		  iVar3 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_List_CombatPlayer___TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(iVar1 + 0x70) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar3,System_Action_List_CombatPlayer___TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x70) = iVar4;
		    uVar2 = System_Action_List_CombatPlayer___TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_List_CombatPlayer___TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar1 + 0x30);
		  uVar2 = unnamed_function_1417(System_Action_CombatPlayer__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandlePlayerAddedEvent__,0)
		  ;
		  iVar3 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_CombatPlayer__TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(iVar1 + 0x30) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar3,System_Action_CombatPlayer__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x30) = iVar4;
		    uVar2 = System_Action_CombatPlayer__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_CombatPlayer__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar1 + 0x34);
		  uVar2 = unnamed_function_1417(System_Action_CombatPlayer__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandlePlayerRemovedEvent__,
		             0);
		  iVar3 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_CombatPlayer__TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(iVar1 + 0x34) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar3,System_Action_CombatPlayer__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x34) = iVar4;
		    uVar2 = System_Action_CombatPlayer__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_CombatPlayer__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar1 + 0x60);
		  uVar2 = unnamed_function_1417(System_Action_IList_CombatPlayer___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandleEffectsChangedEvent__
		             ,0);
		  iVar3 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_IList_CombatPlayer___TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(iVar1 + 0x60) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar3,System_Action_IList_CombatPlayer___TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x60) = iVar4;
		    uVar2 = System_Action_IList_CombatPlayer___TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_IList_CombatPlayer___TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar1 + 0x6c);
		  uVar2 = unnamed_function_1417(System_Action_CombatPlayer__string__TypeInfo);
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		            (uVar2,param1,
		             Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandleChatEvent__,0);
		  iVar3 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_CombatPlayer__string__TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(iVar1 + 0x6c) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar3,System_Action_CombatPlayer__string__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x6c) = iVar4;
		    uVar2 = System_Action_CombatPlayer__string__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_CombatPlayer__string__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar3 + 0x74);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator_HandleJointEvent__,0);
		  param1_00 = (int *)func_ii_7048(uVar5,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(iVar3 + 0x74) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *param1_00) &&
		     (*(int **)(iVar3 + 0x74) = param1_00, *param1_00 == iVar1)) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_00,iVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600419A RID: 16794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600419A")]
		[Address(RVA = "0x9051", Offset = "0x9051", VA = "0x9051", Slot = "30")]
		protected override void RemoveGameProcessEventsHandlers()
		{
		/* --- GHIDRA: RemoveGameProcessEventsHandlers ---
		void Gameplay_Clans_Combat_Control_ClanCombatViewMediator__RemoveGameProcessEventsHandlers
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a577b5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_ClanCombatPlayer__get_DestroyInstantElements__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_ClanCombatPlayer__get_HideInstantElements__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_CombatGameOverView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator__HandleGameOver_b__6_0__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a577b5 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = *(int *)(iVar2 + 0x3c);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(iVar2 + iVar1 * 4 + 0x10),0,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = *(int *)(iVar1 + 0x40);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    iVar2 = 0;
		    do {
		      uVar4 = *(undefined4 *)(iVar1 + iVar2 * 4 + 0x10);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      UnityEngine_Application__get_isPlaying(uVar4,0);
		      iVar2 = iVar2 + 1;
		    } while (iVar2 < *(int *)(iVar1 + 0xc));
		  }
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = param1[2];
		  uVar5 = *(undefined4 *)(iVar1 + 0x10);
		  uVar4 = unnamed_function_1417(System_Action_CombatGameOverView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_Clans_Combat_Control_ClanCombatViewMediator__HandleGameOver_b__6_0__,0)
		  ;
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x118) * 4))
		            (piVar3,iVar1,uVar5,uVar4,*(undefined4 *)(*piVar3 + 0x11c));
		  return;
		}
		*/

		}

		// Token: 0x0600419B RID: 16795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600419B")]
		[Address(RVA = "0x9052", Offset = "0x9052", VA = "0x9052", Slot = "37")]
		protected override void HandleGameOver()
		{
		/* --- GHIDRA: HandleGameOver ---
		int Gameplay_Clans_Combat_Control_ClanCombatViewMediator__HandleGameOver
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a577b6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatView__HandleGameOverWindowCloseRequestEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatView__get_Model__
		              );
		    DAT_ram_00a577b6 = '\x01';
		  }
		  param2_00 = *(undefined4 *)(*(int *)(param1 + 8) + 0x50);
		  iVar1 = Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___HandleGameOver
		                    (param1,param2,
		                     Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatView__HandleGameOverWindowCloseRequestEvent__
		                    );
		  if (iVar1 == 0) {
		    param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		    DefaultNamespace_SceneAppManager__RemoveScene(param1_00,param2_00,0);
		  }
		  return iVar1;
		}
		*/

		}

		// Token: 0x0600419C RID: 16796 RVA: 0x0000C9C0 File Offset: 0x0000ABC0
		[Token(Token = "0x600419C")]
		[Address(RVA = "0x9053", Offset = "0x9053", VA = "0x9053", Slot = "22")]
		protected override bool HandleGameOverWindowCloseRequestEvent(CombatGameOverView view)
		{
		/* --- GHIDRA: HandleGameOverWindowCloseRequestEvent ---
		undefined4
		Gameplay_Clans_Combat_Control_ClanCombatViewMediator__HandleGameOverWindowCloseRequestEvent
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *param1_00;
		  int iVar4;
		  int local_4;
		  
		  if (DAT_ram_00a577b7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatView__HandleGameOverWindowNextCombatRequestEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_ClanWars_IClanWars_TypeInfo);
		    DAT_ram_00a577b7 = '\x01';
		  }
		  local_4 = 0;
		  param1_00 = *(int **)(param1[2] + 0x60);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Clans_ClanWars_IClanWars_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)
		         ) {
		        puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80ddd0a5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Gameplay_Clans_ClanWars_IClanWars_TypeInfo,0);
		code_r0x80ddd0a5:
		  iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,&local_4,puVar3[1]);
		  if ((iVar4 == 0) || (*(int *)(*(int *)(local_4 + 0xc) + 0x1c) == 2)) {
		    uVar2 = 1;
		    iVar4 = Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___HandleGameOverWindowCloseRequestEvent
		                      (param1,param2,
		                       Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatView__HandleGameOverWindowNextCombatRequestEvent__
		                      );
		    if (iVar4 == 0) {
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      uVar2 = 0;
		      Gameplay_Clans_Combat_ClanCombat__InitMVC
		                (**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c),0);
		    }
		  }
		  else {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x170) * 4))
		                      (param1,param2,*(undefined4 *)(*param1 + 0x174));
		  }
		  return uVar2;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600419D RID: 16797 RVA: 0x0000C9D8 File Offset: 0x0000ABD8
		[Token(Token = "0x600419D")]
		[Address(RVA = "0x9054", Offset = "0x9054", VA = "0x9054", Slot = "21")]
		protected override bool HandleGameOverWindowNextCombatRequestEvent(CombatGameOverView view)
		{
		/* --- GHIDRA: HandleGameOverWindowNextCombatRequestEvent ---
		void Gameplay_Clans_Combat_Control_ClanCombatViewMediator__HandleGameOverWindowNextCombatRequestEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Clans_Combat_Control_ClanCombatController__NotifyShowViewProcessComplete
		            (param1_00,param1);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600419E RID: 16798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600419E")]
		[Address(RVA = "0x9055", Offset = "0x9055", VA = "0x9055")]
		private void HandleExitFromViewMoveClickEvent()
		{
		/* --- GHIDRA: HandleExitFromViewMoveClickEvent ---
		void Gameplay_Clans_Combat_Control_ClanCombatViewMediator__HandleExitFromViewMoveClickEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  int local_4;
		  
		  if (DAT_ram_00a577b8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_ClanWars_IClanWars_TypeInfo);
		    DAT_ram_00a577b8 = '\x01';
		  }
		  local_4 = 0;
		  param1_01 = *(int **)(param1[2] + 0x60);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Clans_ClanWars_IClanWars_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80ddd214;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Gameplay_Clans_ClanWars_IClanWars_TypeInfo,0);
		code_r0x80ddd214:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,&local_4,puVar2[1]);
		  if (iVar3 != 0) {
		    iVar3 = *param1;
		    param1_00 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x148) * 4))
		                          (param1,*(undefined4 *)(iVar3 + 0x14c));
		    Gameplay_Clans_Combat_Control_ClanCombatController__HandleJoinCombatAsViewerService
		              (param1_00,*(undefined4 *)(*(int *)(local_4 + 0xc) + 0xc),iVar3);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600419F RID: 16799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600419F")]
		[Address(RVA = "0x9056", Offset = "0x9056", VA = "0x9056")]
		private void HandleStartCombatClickEvent()
		{
		}

		// Token: 0x060041A0 RID: 16800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A0")]
		[Address(RVA = "0x9057", Offset = "0x9057", VA = "0x9057")]
		private void HandleChatEvent(CombatPlayer arg1, string arg2)
		{
		/* --- GHIDRA: HandleChatEvent ---
		void Gameplay_Clans_Combat_Control_ClanCombatViewMediator__HandleChatEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a577b9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_CombatPlayer__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_CombatPlayer__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_CombatPlayer__get_Current__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Sound_Control_IGameAudio_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CombatPlayer__GetEnumerator__);
		    DAT_ram_00a577b9 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  piVar5 = *(int **)(*(int *)(param1[2] + 0x3c) + 0x1c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Sound_Control_IGameAudio_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 200);
		        goto code_r0x80ddd337;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Gameplay_Sound_Control_IGameAudio_TypeInfo,1);
		code_r0x80ddd337:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar5,0xc,puVar2[1]);
		  Gameplay_Clans_Combat_Control_ClanCombatViewMediator__SetSpellElixirs(param1,&local_20);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_RightPanel_TitleWithLevel__set_Level
		            (*(undefined4 *)(iVar6 + 100),*(undefined4 *)(param1[2] + 0x7c),0);
		  piVar5 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x148) * 4))
		                    (piVar5,*(undefined4 *)(piVar5[3] + 0x2c),*(undefined4 *)(*piVar5 + 0x14c));
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,uVar3,Method_System_Collections_Generic_List_CombatPlayer__GetEnumerator__);
		  local_20 = 0;
		  local_1c = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_CombatPlayer__MoveNext__);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ddd467;
		    }
		    if (iVar4 == 0) goto code_r0x80ddd4bd;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x359,param1,local_8._4_4_,
		               &local_20);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar6 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ddd467:
		  iVar6 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar4 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar4;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		      if (iVar4 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80ddd4bd:
		      DAT_ram_009d3e38 = 0;
		      piVar5 = (int *)param1[2];
		      uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x150) * 4))
		                        (piVar5,*(undefined4 *)(piVar5[3] + 0x2c),*(undefined4 *)(*piVar5 + 0x154));
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_20,uVar3,
		                 Method_System_Collections_Generic_List_CombatPlayer__GetEnumerator__);
		      local_8 = local_18;
		      local_10 = CONCAT44(local_1c,local_20);
		      local_20 = 0;
		      local_1c = &local_10;
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                           Method_System_Collections_Generic_List_Enumerator_CombatPlayer__MoveNext__
		                          );
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80ddd5e4;
		        }
		        if (iVar4 == 0) goto code_r0x80ddd685;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x359,param1,local_8._4_4_,
		                   &local_20);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar6 != 1);
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ddd5e4:
		      iVar6 = global_1;
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar6 == iVar4) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar4 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar4;
		        import::env::invoke_v(0x123);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 != 1) {
		          if (iVar4 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x80ddd685:
		          DAT_ram_009d3e38 = 0;
		          Gameplay_Clans_Combat_Control_ClanCombatViewMediator__HandlePlayersMovedEvent
		                    (param1,&local_20);
		          piVar5 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                                    (param1,*(undefined4 *)(*param1 + 0x15c));
		          (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xf8) * 4))
		                    (piVar5,*(undefined4 *)(*piVar5 + 0xfc));
		          iVar6 = *(int *)param1[2];
		          uVar3 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x100) * 4))
		                            ((int *)param1[2],*(undefined4 *)(iVar6 + 0x104));
		          Gameplay_Clans_Combat_Control_ClanCombatViewMediator__ShowCurrentPlayersInfo
		                    (param1,uVar3,&local_20);
		          return;
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x35d,&local_20);
		      goto joined_r0x80ddd671;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x35c,&local_20);
		joined_r0x80ddd671:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060041A1 RID: 16801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A1")]
		[Address(RVA = "0x9058", Offset = "0x9058", VA = "0x9058")]
		private void HandleJointEvent()
		{
		/* --- GHIDRA: HandleJointEvent ---
		void Gameplay_Clans_Combat_Control_ClanCombatViewMediator__HandleJointEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  bool bVar1;
		  bool bVar2;
		  bool bVar3;
		  uint uVar4;
		  uint *puVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  int iVar9;
		  longlong lVar10;
		  longlong lVar11;
		  longlong lVar12;
		  int iVar13;
		  int *piVar14;
		  int *piVar15;
		  int *local_8;
		  undefined4 local_4;
		  
		  iVar9 = 0;
		  bVar3 = false;
		  if (DAT_ram_00a577ba == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatView__HandleUserSkillsChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Contains_CombatPlayer___);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_CombatPlayer__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Sound_Control_IGameAudio_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_CombatPlayer__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Players_Pet_IPetView_TypeInfo);
		    DAT_ram_00a577ba = '\x01';
		  }
		  local_4 = 0;
		  local_8 = (int *)0x0;
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___HandleUserBalanceChangedEvent
		            (param1,param2,
		             Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatView__HandleUserSkillsChangedEvent__
		            );
		  do {
		    iVar13 = *param2;
		    if (*(ushort *)(iVar13 + 0xb6) != 0) {
		      uVar4 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar13 + 0x58) + uVar4 * 8);
		        if (System_Collections_Generic_ICollection_CombatPlayer__TypeInfo == *piVar7) {
		          puVar5 = (uint *)(iVar13 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80ddd7dc;
		        }
		        uVar4 = uVar4 + 1;
		      } while (*(ushort *)(iVar13 + 0xb6) != uVar4);
		    }
		    puVar5 = (uint *)func_ii_1080(param2,
		                                  System_Collections_Generic_ICollection_CombatPlayer__TypeInfo,0);
		code_r0x80ddd7dc:
		    iVar13 = (**(code **)((ulonglong)*puVar5 * 4))(param2,puVar5[1]);
		    if (iVar13 <= iVar9) {
		      return;
		    }
		    iVar13 = *param2;
		    if (*(ushort *)(iVar13 + 0xb6) != 0) {
		      uVar4 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar13 + 0x58) + uVar4 * 8);
		        if (System_Collections_Generic_IList_CombatPlayer__TypeInfo == *piVar7) {
		          puVar5 = (uint *)(iVar13 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80ddd85b;
		        }
		        uVar4 = uVar4 + 1;
		      } while (*(ushort *)(iVar13 + 0xb6) != uVar4);
		    }
		    puVar5 = (uint *)func_ii_1080(param2,System_Collections_Generic_IList_CombatPlayer__TypeInfo,0);
		code_r0x80ddd85b:
		    iVar13 = (**(code **)((ulonglong)*puVar5 * 4))(param2,iVar9,puVar5[1]);
		    iVar6 = Gameplay_Clans_Combat_Model_ClanCombatModel__GetPlayerCount(param1[2],&local_4,puVar5);
		    if ((iVar6 != 0) &&
		       (iVar6 = System_Uri__get_Scheme
		                          (local_4,iVar13,Method_System_Linq_Enumerable_Contains_CombatPlayer___),
		       iVar6 != 0)) {
		      iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      lVar10 = *(longlong *)(iVar13 + 0x48);
		      lVar11 = *(longlong *)(iVar13 + 0x30);
		      lVar12 = *(longlong *)(iVar13 + 0x28);
		      iVar8 = 0x5c;
		      if (*(int *)(iVar13 + 0x54) != *(int *)(*(int *)(iVar13 + 8) + 0x14)) {
		        iVar8 = 0x60;
		      }
		      piVar7 = *(int **)(iVar6 + iVar8);
		      iVar6 = *piVar7;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar4 = 0;
		        do {
		          piVar15 = (int *)(*(int *)(iVar6 + 0x58) + uVar4 * 8);
		          if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo == *piVar15) {
		            puVar5 = (uint *)(piVar15[1] * 8 + iVar6 + 200);
		            goto code_r0x80ddd946;
		          }
		          uVar4 = uVar4 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar4);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar7,Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo,1
		                                   );
		code_r0x80ddd946:
		      (**(code **)((ulonglong)*puVar5 * 4))(piVar7,0xffffffff,puVar5[1]);
		      bVar1 = lVar12 != 0;
		      bVar2 = bVar3;
		      if (*(int *)(iVar13 + 0x1c) != 0 && lVar10 != 0) {
		        iVar6 = *piVar7;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          uVar4 = 0;
		          do {
		            piVar15 = (int *)(*(int *)(iVar6 + 0x58) + uVar4 * 8);
		            if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo == *piVar15) {
		              puVar5 = (uint *)(piVar15[1] * 8 + iVar6 + 0xf0);
		              goto code_r0x80ddd9ee;
		            }
		            uVar4 = uVar4 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar4);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar7,Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo
		                                      ,6);
		code_r0x80ddd9ee:
		        iVar6 = (**(code **)((ulonglong)*puVar5 * 4))(piVar7,&local_8,puVar5[1]);
		        piVar15 = local_8;
		        if (iVar6 != 0) {
		          iVar8 = *local_8;
		          if (*(ushort *)(iVar8 + 0xb6) != 0) {
		            uVar4 = 0;
		            do {
		              piVar14 = (int *)(*(int *)(iVar8 + 0x58) + uVar4 * 8);
		              if (Gameplay_Combat_View_Players_Pet_IPetView_TypeInfo == *piVar14) {
		                puVar5 = (uint *)(piVar14[1] * 8 + iVar8 + 0xf8);
		                goto code_r0x80ddda75;
		              }
		              uVar4 = uVar4 + 1;
		            } while (*(ushort *)(iVar8 + 0xb6) != uVar4);
		          }
		          puVar5 = (uint *)func_ii_1080(local_8,Gameplay_Combat_View_Players_Pet_IPetView_TypeInfo,7
		                                       );
		code_r0x80ddda75:
		          (**(code **)((ulonglong)*puVar5 * 4))(piVar15,0,puVar5[1]);
		          bVar2 = bVar1;
		          if (iVar6 == 0) {
		            bVar1 = bVar3;
		            bVar2 = bVar3;
		          }
		        }
		      }
		      if (bVar1) {
		        if (0 < *(longlong *)(iVar13 + 0x28)) {
		          piVar15 = *(int **)(*(int *)(param1[2] + 0x3c) + 0x1c);
		          iVar6 = *piVar15;
		          if (*(ushort *)(iVar6 + 0xb6) != 0) {
		            uVar4 = 0;
		            do {
		              piVar14 = (int *)(*(int *)(iVar6 + 0x58) + uVar4 * 8);
		              if (Gameplay_Sound_Control_IGameAudio_TypeInfo == *piVar14) {
		                puVar5 = (uint *)(piVar14[1] * 8 + iVar6 + 200);
		                goto code_r0x80dddb19;
		              }
		              uVar4 = uVar4 + 1;
		            } while (*(ushort *)(iVar6 + 0xb6) != uVar4);
		          }
		          puVar5 = (uint *)func_ii_1080(piVar15,Gameplay_Sound_Control_IGameAudio_TypeInfo,1);
		code_r0x80dddb19:
		          (**(code **)((ulonglong)*puVar5 * 4))(piVar15,0x16,puVar5[1]);
		        }
		        iVar6 = *piVar7;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          uVar4 = 0;
		          do {
		            piVar15 = (int *)(*(int *)(iVar6 + 0x58) + uVar4 * 8);
		            if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo == *piVar15) {
		              puVar5 = (uint *)(piVar15[1] * 8 + iVar6 + 200);
		              goto code_r0x80dddb9a;
		            }
		            uVar4 = uVar4 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar4);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar7,Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo
		                                      ,1);
		code_r0x80dddb9a:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar7,3,puVar5[1]);
		      }
		      bVar3 = bVar2;
		      if (lVar11 != 0) {
		        if (0 < *(longlong *)(iVar13 + 0x30)) {
		          piVar15 = *(int **)(*(int *)(param1[2] + 0x3c) + 0x1c);
		          iVar13 = *piVar15;
		          if (*(ushort *)(iVar13 + 0xb6) != 0) {
		            uVar4 = 0;
		            do {
		              piVar14 = (int *)(*(int *)(iVar13 + 0x58) + uVar4 * 8);
		              if (Gameplay_Sound_Control_IGameAudio_TypeInfo == *piVar14) {
		                puVar5 = (uint *)(piVar14[1] * 8 + iVar13 + 200);
		                goto code_r0x80dddc2b;
		              }
		              uVar4 = uVar4 + 1;
		            } while (*(ushort *)(iVar13 + 0xb6) != uVar4);
		          }
		          puVar5 = (uint *)func_ii_1080(piVar15,Gameplay_Sound_Control_IGameAudio_TypeInfo,1);
		code_r0x80dddc2b:
		          (**(code **)((ulonglong)*puVar5 * 4))(piVar15,0x15,puVar5[1]);
		        }
		        iVar13 = *piVar7;
		        if (*(ushort *)(iVar13 + 0xb6) != 0) {
		          uVar4 = 0;
		          do {
		            piVar15 = (int *)(*(int *)(iVar13 + 0x58) + uVar4 * 8);
		            if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo == *piVar15) {
		              puVar5 = (uint *)(piVar15[1] * 8 + iVar13 + 200);
		              goto code_r0x80dddcac;
		            }
		            uVar4 = uVar4 + 1;
		          } while (*(ushort *)(iVar13 + 0xb6) != uVar4);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar7,Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo
		                                      ,1);
		code_r0x80dddcac:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar7,4,puVar5[1]);
		      }
		    }
		    iVar9 = iVar9 + 1;
		  } while( true );
		}
		*/

		}

		// Token: 0x060041A2 RID: 16802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A2")]
		[Address(RVA = "0x9059", Offset = "0x9059", VA = "0x9059", Slot = "27")]
		protected override void HandleUserSkillsChangedEvent(IList<CombatPlayer> players)
		{
		/* --- GHIDRA: HandleUserSkillsChangedEvent ---
		void Gameplay_Clans_Combat_Control_ClanCombatViewMediator__HandleUserSkillsChangedEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  int iVar7;
		  int *piVar8;
		  int iVar9;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a577bb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_CombatPlayer__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_CombatPlayer__TypeInfo);
		    DAT_ram_00a577bb = '\x01';
		  }
		  iVar6 = *param2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_CombatPlayer__TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80dddd6f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,System_Collections_Generic_ICollection_CombatPlayer__TypeInfo
		                                ,0);
		code_r0x80dddd6f:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  if (0 < iVar6) {
		    do {
		      iVar9 = *param2;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar4 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IList_CombatPlayer__TypeInfo == *piVar4) {
		            puVar2 = (uint *)(iVar9 + piVar4[1] * 8 + 0xc0);
		            goto code_r0x80ddddf2;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param2,System_Collections_Generic_IList_CombatPlayer__TypeInfo,0
		                                   );
		code_r0x80ddddf2:
		      iVar9 = (**(code **)((ulonglong)*puVar2 * 4))(param2,iVar5,puVar2[1]);
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar7 = 0x5c;
		      if (*(int *)(iVar9 + 0x54) != *(int *)(*(int *)(iVar9 + 8) + 0x14)) {
		        iVar7 = 0x60;
		      }
		      piVar4 = *(int **)(iVar3 + iVar7);
		      iVar9 = *piVar4;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		          if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo == *piVar8) {
		            puVar2 = (uint *)(piVar8[1] * 8 + iVar9 + 0xd8);
		            goto code_r0x80ddde9d;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar4,Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo,3
		                                   );
		code_r0x80ddde9d:
		      (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		      iVar5 = iVar5 + 1;
		    } while (iVar5 != iVar6);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060041A3 RID: 16803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A3")]
		[Address(RVA = "0x905A", Offset = "0x905A", VA = "0x905A")]
		private void HandleEffectsChangedEvent(IList<CombatPlayer> players)
		{
		/* --- GHIDRA: HandleEffectsChangedEvent ---
		void Gameplay_Clans_Combat_Control_ClanCombatViewMediator__HandleEffectsChangedEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  int *piVar1;
		  
		  if (DAT_ram_00a577bc == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Combat_Model_ClanCombatPlayer_TypeInfo);
		    DAT_ram_00a577bc = '\x01';
		  }
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Clans_Combat_Model_ClanCombatPlayer_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param2 + 100) +
		                 (uint)*(byte *)(Gameplay_Clans_Combat_Model_ClanCombatPlayer_TypeInfo + 0xb8) * 4 +
		                -4) != Gameplay_Clans_Combat_Model_ClanCombatPlayer_TypeInfo)) {
		      System_Activator__CreateInstance(param2,Gameplay_Clans_Combat_Model_ClanCombatPlayer_TypeInfo)
		      ;
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		            (piVar1,param2,*(undefined4 *)(*piVar1 + 0x134));
		  Gameplay_Clans_Combat_Control_ClanCombatViewMediator__HandlePlayersMovedEvent(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060041A4 RID: 16804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A4")]
		[Address(RVA = "0x905B", Offset = "0x905B", VA = "0x905B")]
		private void HandlePlayerRemovedEvent(CombatPlayer player)
		{
		/* --- GHIDRA: HandlePlayerRemovedEvent ---
		void Gameplay_Clans_Combat_Control_ClanCombatViewMediator__HandlePlayerRemovedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int param2_01;
		  int iVar1;
		  int iVar2;
		  
		  param2_01 = 0;
		  param2_00 = 0;
		  if (DAT_ram_00a577be == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CombatPlayer__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CombatPlayer__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CombatPlayer__InsertOneAtEnd__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CombatPlayer__RemoveOne__
		              );
		    DAT_ram_00a577be = '\x01';
		  }
		  if (0 < *(int *)(param2 + 0xc)) {
		    do {
		      param2_01 = System_Linq_Enumerable__ToList_object_
		                            (param2,param2_00,
		                             Method_System_Collections_Generic_List_CombatPlayer__get_Item__);
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar2 = 0x4c;
		      if (*(int *)(*(int *)(param2_01 + 8) + 0x14) != *(int *)(param2_01 + 0x54)) {
		        iVar2 = 0x50;
		      }
		      iVar1 = *(int *)(iVar1 + iVar2);
		      Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveItemsFromStart
		                (*(undefined4 *)(iVar1 + 0xa8),0,0,
		                 Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CombatPlayer__RemoveOne__
		                );
		      Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___InsertOne
		                (*(undefined4 *)(iVar1 + 0xa8),param2_01,0,
		                 Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CombatPlayer__InsertOneAtEnd__
		                );
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(param2 + 0xc));
		  }
		  Gameplay_Clans_Combat_Control_ClanCombatViewMediator__HandlePlayersMovedEvent(param1,param2_01);
		  return;
		}
		*/

		}

		// Token: 0x060041A5 RID: 16805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A5")]
		[Address(RVA = "0x1B21", Offset = "0x1B21", VA = "0x1B21")]
		private void HandlePlayerAddedEvent(CombatPlayer player)
		{
		/* --- GHIDRA: HandlePlayerAddedEvent ---
		int * Gameplay_Clans_Combat_Control_ClanCombatViewMediator__HandlePlayerAddedEvent(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060041A6 RID: 16806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A6")]
		[Address(RVA = "0x905C", Offset = "0x905C", VA = "0x905C")]
		private void HandlePlayersMovedEvent(List<CombatPlayer> players)
		{
		/* --- GHIDRA: HandlePlayersMovedEvent ---
		void Gameplay_Clans_Combat_Control_ClanCombatViewMediator__HandlePlayersMovedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  float param2_00;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  undefined4 uVar7;
		  int iVar8;
		  undefined4 uVar9;
		  int iVar10;
		  int *piVar11;
		  int *piVar12;
		  int iVar13;
		  undefined4 local_8;
		  int local_4;
		  
		  iVar13 = 0;
		  if (DAT_ram_00a577bf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a577bf = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  iVar3 = Gameplay_Clans_Combat_Model_ClanCombatModel__GetPlayerCount(param1[2],&local_4,0);
		  iVar1 = local_4;
		  if ((iVar3 != 0) && (0 < *(int *)(local_4 + 0xc))) {
		    uVar7 = 0;
		    do {
		      iVar8 = *(int *)(iVar1 + iVar13 * 4 + 0x10);
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar10 = 0x5c;
		      if (*(int *)(iVar8 + 0x54) != *(int *)(*(int *)(iVar8 + 8) + 0x14)) {
		        iVar10 = 0x60;
		      }
		      piVar6 = *(int **)(iVar3 + iVar10);
		      iVar3 = *piVar6;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          piVar12 = (int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8);
		          if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo == *piVar12) {
		            puVar4 = (uint *)(piVar12[1] * 8 + iVar3 + 0xf8);
		            goto code_r0x80ddc05d;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar6,Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo,7
		                                   );
		code_r0x80ddc05d:
		      iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		      if (iVar3 == 0) {
		        uVar9 = *(undefined4 *)(*(int *)(param1[2] + 0x3c) + 0x1c);
		        piVar12 = *(int **)(*(int *)(param1[2] + 0x3c) + 0x18);
		        iVar3 = *piVar12;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8);
		            if (Core_Dict_IDictProvider_TypeInfo == *piVar11) {
		              puVar4 = (uint *)(piVar11[1] * 8 + iVar3 + 0xd0);
		              goto code_r0x80ddc0f0;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		        }
		        puVar4 = (uint *)func_ii_1080(piVar12,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80ddc0f0:
		        uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar12,puVar4[1]);
		        iVar3 = *piVar6;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar12 = (int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8);
		            if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo == *piVar12) {
		              puVar4 = (uint *)(iVar3 + piVar12[1] * 8 + 0xc0);
		              goto code_r0x80ddc174;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		        }
		        puVar4 = (uint *)func_ii_1080(piVar6,Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo
		                                      ,0);
		code_r0x80ddc174:
		        (**(code **)((ulonglong)*puVar4 * 4))(piVar6,iVar8,uVar9,uVar5,puVar4[1]);
		      }
		      else {
		        iVar3 = *piVar6;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar12 = (int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8);
		            if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo == *piVar12) {
		              puVar4 = (uint *)(piVar12[1] * 8 + iVar3 + 0x108);
		              goto code_r0x80ddc1f2;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		        }
		        puVar4 = (uint *)func_ii_1080(piVar6,Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo
		                                      ,9);
		code_r0x80ddc1f2:
		        (**(code **)((ulonglong)*puVar4 * 4))(piVar6,iVar8,puVar4[1]);
		      }
		      iVar3 = *piVar6;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          piVar12 = (int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8);
		          if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo == *piVar12) {
		            puVar4 = (uint *)(piVar12[1] * 8 + iVar3 + 200);
		            goto code_r0x80ddc26d;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar6,Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo,1
		                                   );
		code_r0x80ddc26d:
		      (**(code **)((ulonglong)*puVar4 * 4))(piVar6,0xffffffff,puVar4[1]);
		      iVar3 = *piVar6;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          piVar12 = (int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8);
		          if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo == *piVar12) {
		            puVar4 = (uint *)(piVar12[1] * 8 + iVar3 + 0xd0);
		            goto code_r0x80ddc2e5;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar6,Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo,2
		                                   );
		code_r0x80ddc2e5:
		      (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		      iVar3 = *piVar6;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          piVar12 = (int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8);
		          if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo == *piVar12) {
		            puVar4 = (uint *)(piVar12[1] * 8 + iVar3 + 0xd8);
		            goto code_r0x80ddc35d;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar6,Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo,3
		                                   );
		code_r0x80ddc35d:
		      (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		      iVar3 = *piVar6;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          piVar12 = (int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8);
		          if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo == *piVar12) {
		            puVar4 = (uint *)(piVar12[1] * 8 + iVar3 + 0xe8);
		            goto code_r0x80ddc3dc;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar6,Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo,5
		                                   );
		code_r0x80ddc3dc:
		      iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,&local_8,puVar4[1]);
		      if (iVar3 != 0) {
		        uVar9 = local_8;
		        if (*(int *)(iVar8 + 0x14) != *(int *)(param1[2] + 0x44)) {
		          uVar9 = uVar7;
		        }
		        uVar7 = uVar9;
		        param2_00 = 0.0;
		        uVar9 = local_8;
		        if (*(int *)(param1[2] + 0x44) == *(int *)(iVar8 + 0x14)) {
		          if (DAT_ram_00a6456f == '\0') {
		            Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		            DAT_ram_00a6456f = '\x01';
		          }
		          piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		          iVar3 = *piVar6;
		          if (*(ushort *)(iVar3 + 0xb6) != 0) {
		            uVar2 = 0;
		            do {
		              piVar12 = (int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8);
		              if (Core_Gameplay_IGame_TypeInfo == *piVar12) {
		                puVar4 = (uint *)(piVar12[1] * 8 + iVar3 + 0x140);
		                goto code_r0x80ddc4ad;
		              }
		              uVar2 = uVar2 + 1;
		            } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		          }
		          puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80ddc4ad:
		          iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		          param2_00 = Gameplay_User_Model_UserModel__get_AvailableCults
		                                (*(undefined4 *)(iVar3 + 0x14),0);
		          uVar9 = uVar7;
		        }
		        Gameplay_UserInterface_View_ClanNickCultIndexView___ctor(uVar9,param2_00,0);
		        if (*(int *)(iVar8 + 0x14) == *(int *)(param1[2] + 0x44)) {
		          Gameplay_UserInterface_View_LevelView__get_IsPremiumExp
		                    (local_8,(uint)*(byte *)(*(int *)(iVar8 + 0x14) + 0x74),0);
		        }
		      }
		      iVar13 = iVar13 + 1;
		    } while (iVar13 < *(int *)(iVar1 + 0xc));
		  }
		  if (*(char *)(param1[2] + 100) != '\0') {
		    piVar6 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x15c));
		    (**(code **)((ulonglong)*(uint *)(*piVar6 + 0xf8) * 4))(piVar6,*(undefined4 *)(*piVar6 + 0xfc));
		    iVar13 = *(int *)param1[2];
		    uVar7 = (**(code **)((ulonglong)*(uint *)(iVar13 + 0x100) * 4))
		                      ((int *)param1[2],*(undefined4 *)(iVar13 + 0x104));
		    Gameplay_Clans_Combat_Control_ClanCombatViewMediator__ShowCurrentPlayersInfo
		              (param1,uVar7,iVar13);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060041A7 RID: 16807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A7")]
		[Address(RVA = "0x905D", Offset = "0x905D", VA = "0x905D")]
		private void ShowCurrentPlayersInfo()
		{
		/* --- GHIDRA: ShowCurrentPlayersInfo ---
		void Gameplay_Clans_Combat_Control_ClanCombatViewMediator__ShowCurrentPlayersInfo
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int *param2_00;
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int param2_01;
		  
		  param2_01 = 0;
		  if (DAT_ram_00a577c0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CombatSpellData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CombatSpellData__get_Item__);
		    DAT_ram_00a577c0 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param2 + 0xc) + 0xc);
		  if (0 < iVar2) {
		    do {
		      param2_00 = (int *)System_Linq_Enumerable__ToList_object_
		                                   (*(undefined4 *)(param2 + 0xc),param2_01,
		                                    Method_System_Collections_Generic_List_CombatSpellData__get_Item__
		                                   );
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param2_00 + 0x120) * 4))
		                        (param2_00,*(undefined4 *)(*param2_00 + 0x124));
		      if (iVar1 != 0) {
		        iVar3 = param2_00[0xb];
		        iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        if (iVar3 == 0) {
		          Gameplay_Combat_View_AbstractCombatView__ResetSpells(iVar1,param2_00,0);
		        }
		        else {
		          Gameplay_Combat_View_AbstractCombatView__AddSpell
		                    (iVar1,param2_00,*(undefined4 *)(iVar1 + 0x48),0);
		        }
		      }
		      param2_01 = param2_01 + 1;
		    } while (param2_01 != iVar2);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060041A8 RID: 16808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A8")]
		[Address(RVA = "0x905E", Offset = "0x905E", VA = "0x905E")]
		private void SetSpellElixirs(CombatPlayer player)
		{
		/* --- GHIDRA: SetSpellElixirs ---
		void Gameplay_Clans_Combat_Control_ClanCombatViewMediator__SetSpellElixirs
		               (int *param1,undefined4 param2)
		
		{
		  char cVar1;
		  uint param2_00;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  int local_4;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a577c1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_ClanWars_IClanWars_TypeInfo);
		    DAT_ram_00a577c1 = '\x01';
		  }
		  local_4 = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x68),0);
		  cVar1 = *(char *)(param1[2] + 100);
		  if (cVar1 != '\0') {
		    param1_00 = *(int **)(param1[2] + 0x60);
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Clans_ClanWars_IClanWars_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + param2_00 * 8)) {
		          puVar4 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + param2_00 * 8 + 4) * 8 + 0xc0)
		          ;
		          goto code_r0x80ddbce9;
		        }
		        param2_00 = param2_00 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != param2_00);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_00,Gameplay_Clans_ClanWars_IClanWars_TypeInfo,0);
		code_r0x80ddbce9:
		    if (cVar1 == '\0') {
		      uVar3 = 0;
		    }
		    param2_00 = 0;
		    iVar2 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,&local_4,puVar4[1]);
		    if (iVar2 != 0) {
		      param2_00 = (uint)(*(int *)(local_4 + 0x10) == 0);
		    }
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,param2_00,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x6c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,(uint)*(byte *)(param1[2] + 100),0);
		  return;
		}
		*/

		}

		// Token: 0x060041A9 RID: 16809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A9")]
		[Address(RVA = "0x905F", Offset = "0x905F", VA = "0x905F")]
		private void ValidateViewMode()
		{
		/* --- GHIDRA: ValidateViewMode ---
		void Gameplay_Clans_Combat_Control_ClanCombatViewMediator__ValidateViewMode
		               (int *param1,int param2,undefined4 param3)
		
		{
		  char cVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int iVar5;
		  undefined4 param1_00;
		  int *piVar6;
		  
		  if (DAT_ram_00a577c2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_CombatGameOverView__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Sound_Control_IGameAudio_TypeInfo);
		    DAT_ram_00a577c2 = '\x01';
		  }
		  param1[7] = param2;
		  uVar3 = unnamed_function_1417(System_Func_CombatGameOverView__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar3,param1,*(undefined4 *)(*param1 + 0x174),0);
		  Gameplay_Combat_View_CombatEventsToast___ctor(param2,uVar3,0);
		  iVar5 = param1[7];
		  uVar3 = unnamed_function_1417(System_Func_CombatGameOverView__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar3,param1,*(undefined4 *)(*param1 + 0x16c),0);
		  Gameplay_Combat_View_CombatGameOverView__remove_CloseRequestEvent(iVar5,uVar3,0);
		  param1_00 = *(undefined4 *)(param1[7] + 0x38);
		  uVar3 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout(uVar3,param1,*(undefined4 *)(*param1 + 500),0);
		  UI_IndexButtonBasic__get_CanvasGroup(param1_00,uVar3,0);
		  piVar6 = *(int **)(*(int *)(param1[2] + 0x3c) + 0x1c);
		  iVar5 = *piVar6;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Gameplay_Sound_Control_IGameAudio_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)
		         ) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x80dde170;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Gameplay_Sound_Control_IGameAudio_TypeInfo,3);
		code_r0x80dde170:
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar2 = 0;
		  cVar1 = *(char *)(*(int *)(param1[2] + 0x10) + 8);
		  piVar6 = *(int **)(*(int *)(param1[2] + 0x3c) + 0x1c);
		  iVar5 = *piVar6;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Sound_Control_IGameAudio_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)
		         ) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x80dde205;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Gameplay_Sound_Control_IGameAudio_TypeInfo,1);
		code_r0x80dde205:
		  uVar3 = 0x18;
		  if (cVar1 == '\0') {
		    uVar3 = 0x19;
		  }
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar6,uVar3,puVar4[1]);
		  return;
		}
		*/

		}
	}
}
