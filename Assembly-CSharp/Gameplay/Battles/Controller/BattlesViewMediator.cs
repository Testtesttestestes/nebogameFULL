using System;
using Gameplay.Battles.Events;
using Gameplay.Battles.Model;
using Gameplay.Battles.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.Battles.Controller
{
	// Token: 0x02000C31 RID: 3121
	[Token(Token = "0x2000C31")]
	public class BattlesViewMediator : AbstractViewMediator<BattlesModel, BattlesEvents, BattlesController, BattlesWindow>
	{
		// Token: 0x06004C18 RID: 19480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C18")]
		[Address(RVA = "0x9A5C", Offset = "0x9A5C", VA = "0x9A5C")]
		public BattlesViewMediator(BattlesModel model, BattlesEvents events, BattlesController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Battles_Controller_BattlesViewMediator___ctor(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 param2_00;
		  int iVar5;
		  int iVar6;
		  int *param1_00;
		  int iVar7;
		  int *piVar8;
		  
		  iVar7 = 0;
		  if (DAT_ram_00a6098a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a6098a = '\x01';
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar2,0);
		  if (iVar3 != 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar5 = *(int *)(iVar3 + 0x3c);
		    iVar3 = *(int *)(iVar5 + 0xc);
		    if (0 < iVar3) {
		      do {
		        iVar6 = *(int *)(iVar5 + iVar7 * 4 + 0x10);
		        if (*(int *)(iVar6 + 0x20) == 5) {
		          uVar2 = *(undefined4 *)(iVar6 + 0x1c);
		          if (DAT_ram_00a6456f == '\0') {
		            Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		            DAT_ram_00a6456f = '\x01';
		          }
		          param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		          iVar3 = *param1_00;
		          if (*(ushort *)(iVar3 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar8 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		              if (Core_Gameplay_IGame_TypeInfo == *piVar8) {
		                puVar4 = (uint *)(piVar8[1] * 8 + iVar3 + 0x1e0);
		                goto code_r0x81d08a94;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		          }
		          puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x24);
		code_r0x81d08a94:
		          iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		          param2_00 = Gameplay_Boss_Model_BossModel__set_CurrentMinion
		                                (*(undefined4 *)(iVar3 + 0x18),0);
		          System_Collections_Generic_Dictionary_int__object___get_Count(uVar2,param2_00,0);
		          iVar3 = *(int *)(iVar5 + 0xc);
		        }
		        iVar7 = iVar7 + 1;
		      } while (iVar7 < iVar3);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004C19 RID: 19481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C19")]
		[Address(RVA = "0x9A5D", Offset = "0x9A5D", VA = "0x9A5D")]
		private void BossTotalNotificationNumChangedEvent()
		{
		/* --- GHIDRA: BossTotalNotificationNumChangedEvent ---
		void Gameplay_Battles_Controller_BattlesViewMediator__BossTotalNotificationNumChangedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a6098b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BattlesModel__BattlesEvents__BattlesController__BattlesWindow__Dispose__
		              );
		    DAT_ram_00a6098b = '\x01';
		  }
		  Gameplay_Battles_Controller_BattlesViewMediator__ListenEventDuelState(param1,param1);
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_BattlesModel__BattlesEvents__BattlesController__BattlesWindow__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004C1A RID: 19482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C1A")]
		[Address(RVA = "0x9A5E", Offset = "0x9A5E", VA = "0x9A5E", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Battles_Controller_BattlesViewMediator__Dispose
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a6098c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BattlesModel__BattlesEvents__BattlesController__BattlesWindow__set_View__
		              );
		    DAT_ram_00a6098c = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Battles_Controller_BattlesViewMediator__ListenEventDuelState(param1,param1);
		    Gameplay_Battles_Controller_BattlesViewMediator__OnCurrentThemeDuelChanged(param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Battles_Controller_BattlesViewMediator__set_View(param1,param1);
		    Gameplay_Battles_Controller_BattlesViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000F57 RID: 3927
		// (set) Token: 0x06004C1B RID: 19483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F57")]
		public override BattlesWindow View
		{
			[Token(Token = "0x6004C1B")]
			[Address(RVA = "0x9A5F", Offset = "0x9A5F", VA = "0x9A5F", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004C1C RID: 19484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C1C")]
		[Address(RVA = "0x9A60", Offset = "0x9A60", VA = "0x9A60")]
		private void ListenEventDuelState()
		{
		/* --- GHIDRA: ListenEventDuelState ---
		void Gameplay_Battles_Controller_BattlesViewMediator__ListenEventDuelState
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  int iVar6;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a6098e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BattlesModel__BattlesEvents__BattlesController__BattlesWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ThemeDuelDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Battles_Controller_BattlesViewMediator_OnCurrentThemeDuelChanged__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a6098e = '\x01';
		  }
		  param1_00 = *(int **)(*(int *)(param1 + 8) + 0xc);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x288);
		        goto code_r0x81d08bb4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x81d08bb4:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar6 = *(int *)(iVar5 + 0x18);
		  param1_01 = *(undefined4 *)(iVar6 + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_ThemeDuelDic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Battles_Controller_BattlesViewMediator_OnCurrentThemeDuelChanged__,0);
		  iVar5 = func_ii_7048(param1_01,uVar3,0);
		  uVar3 = System_Action_ThemeDuelDic__TypeInfo;
		  if (iVar5 == 0) {
		    *(undefined4 *)(iVar6 + 0x18) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar5,System_Action_ThemeDuelDic__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar6 + 0x18) = iVar4;
		    uVar3 = System_Action_ThemeDuelDic__TypeInfo;
		    iVar6 = func_ii_1082(iVar5,System_Action_ThemeDuelDic__TypeInfo);
		    if (iVar6 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar5,uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar5,uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004C1D RID: 19485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C1D")]
		[Address(RVA = "0x9A61", Offset = "0x9A61", VA = "0x9A61")]
		private void UnlistenEventDuelState()
		{
		/* --- GHIDRA: UnlistenEventDuelState ---
		void Gameplay_Battles_Controller_BattlesViewMediator__UnlistenEventDuelState
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *piVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 uVar8;
		  undefined4 param2_00;
		  int iVar9;
		  int iVar10;
		  int *piVar11;
		  
		  iVar9 = 0;
		  if (DAT_ram_00a6098f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BattlesModel__BattlesEvents__BattlesController__BattlesWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Battles_View_ThemeDuelBattlesWndButton_TypeInfo);
		    DAT_ram_00a6098f = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = *(int *)(iVar2 + 0x3c);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    if (param2 == 0) {
		      do {
		        uVar3 = 0;
		        iVar7 = *(int *)(iVar2 + iVar9 * 4 + 0x10);
		        iVar10 = *(int *)(iVar7 + 0x20);
		        if (iVar10 == 8) {
		          uVar3 = 1;
		code_r0x81d098a6:
		          uVar8 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (iVar7,0);
		          Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                    (uVar8,uVar3,0);
		        }
		        else if (iVar10 == 9) goto code_r0x81d098a6;
		        iVar9 = iVar9 + 1;
		      } while (iVar9 < *(int *)(iVar2 + 0xc));
		    }
		    else {
		      do {
		        piVar5 = *(int **)(iVar2 + iVar9 * 4 + 0x10);
		        if (piVar5[8] == 8) {
		          uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (piVar5,0);
		          Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                    (uVar3,0,0);
		        }
		        else if (piVar5[8] == 9) {
		          uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (piVar5,0);
		          Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                    (uVar3,1,0);
		          piVar6 = *(int **)(param1[2] + 0xc);
		          iVar7 = *piVar6;
		          if (*(ushort *)(iVar7 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar11 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		              if (Core_Gameplay_IGame_TypeInfo == *piVar11) {
		                puVar4 = (uint *)(piVar11[1] * 8 + iVar7 + 0x288);
		                goto code_r0x81d09980;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		          }
		          puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x81d09980:
		          iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		          uVar3 = *(undefined4 *)(iVar7 + 0x14);
		          piVar6 = *(int **)(param1[2] + 0xc);
		          iVar7 = *piVar6;
		          if (*(ushort *)(iVar7 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar11 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		              if (Core_Gameplay_IGame_TypeInfo == *piVar11) {
		                puVar4 = (uint *)(piVar11[1] * 8 + iVar7 + 0x1f8);
		                goto code_r0x81d09a07;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		          }
		          puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x81d09a07:
		          iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		          iVar10 = **(int **)(iVar7 + 0x14);
		          iVar7 = (**(code **)((ulonglong)*(uint *)(iVar10 + 0x100) * 4))
		                            (*(int **)(iVar7 + 0x14),*(undefined4 *)(iVar10 + 0x104));
		          uVar8 = *(undefined4 *)(iVar7 + 0x28);
		          piVar6 = *(int **)(param1[2] + 0xc);
		          iVar7 = *piVar6;
		          if (*(ushort *)(iVar7 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar11 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		              if (Core_Gameplay_IGame_TypeInfo == *piVar11) {
		                puVar4 = (uint *)(piVar11[1] * 8 + iVar7 + 0x288);
		                goto code_r0x81d09aa7;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		          }
		          puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x81d09aa7:
		          iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		          uVar8 = Gameplay_Accounts_Model_Data_BattleAccount__GetPartyCombatCost
		                            (uVar8,*(undefined4 *)(iVar7 + 0x14),0);
		          iVar7 = piVar5[6];
		          param2_00 = *(undefined4 *)(param1[2] + 8);
		          if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Core_Money_Money_TypeInfo);
		          }
		          uVar8 = Core_Money_Money__op_Explicit(uVar8,0);
		          UI_Price_Price__SetColor(iVar7,param2_00,uVar8,0);
		          if (*piVar5 == Gameplay_Battles_View_ThemeDuelBattlesWndButton_TypeInfo) {
		            iVar7 = piVar5[0xb];
		            uVar8 = Gameplay_ThemeDuelState_Model_ThemeDuelStateModel__get_HasCurrentThemeDuel
		                              (uVar3,0);
		            uVar8 = Core_Extensions_Dict_ThemeDuelDicExt__GetIcon64AssetId(uVar8,0);
		            Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		                      (iVar7,uVar8,
		                       Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		                      );
		            piVar5 = (int *)piVar5[0xc];
		            uVar3 = Gameplay_ThemeDuelState_Model_ThemeDuelStateModel__get_HasCurrentThemeDuel
		                              (uVar3,0);
		            uVar3 = Core_Extensions_Dict_ThemeDuelDicExt__GetImgForRulesAssetId(uVar3,0);
		            iVar7 = *piVar5;
		            (**(code **)((ulonglong)*(uint *)(iVar7 + 0x2d0) * 4))
		                      (piVar5,uVar3,*(undefined4 *)(iVar7 + 0x2d4));
		          }
		        }
		        iVar9 = iVar9 + 1;
		      } while (iVar9 < *(int *)(iVar2 + 0xc));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004C1E RID: 19486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C1E")]
		[Address(RVA = "0x9A62", Offset = "0x9A62", VA = "0x9A62")]
		private void OnCurrentThemeDuelChanged(ThemeDuelDic td)
		{
		/* --- GHIDRA: OnCurrentThemeDuelChanged ---
		void Gameplay_Battles_Controller_BattlesViewMediator__OnCurrentThemeDuelChanged
		               (int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  uint uVar2;
		  int iVar3;
		  int iVar4;
		  int param1_01;
		  uint *puVar5;
		  undefined4 uVar6;
		  int iVar7;
		  int *piVar8;
		  int iVar9;
		  undefined4 uVar10;
		  
		  iVar9 = 0;
		  if (DAT_ram_00a60990 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BattlesModel__BattlesEvents__BattlesController__BattlesWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_BattlesWndButton__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Battles_Controller_BattlesViewMediator_BossTotalNotificationNumChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Battles_Controller_BattlesViewMediator_BtnEventClickHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Battles_Controller_BattlesViewMediator_HandleUserLevelChanged__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a60990 = '\x01';
		  }
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = *(int *)(iVar4 + 0x3c);
		  if (0 < *(int *)(iVar4 + 0xc)) {
		    do {
		      iVar7 = *(int *)(iVar4 + iVar9 * 4 + 0x10);
		      uVar6 = unnamed_function_1417(System_Action_BattlesWndButton__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar6,param1,
		                 Method_Gameplay_Battles_Controller_BattlesViewMediator_BtnEventClickHandler__,0);
		      if (DAT_ram_00a60972 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_BattlesWndButton__TypeInfo);
		        DAT_ram_00a60972 = '\x01';
		      }
		      param1_00 = *(int *)(iVar7 + 0x28);
		      do {
		        iVar3 = 0;
		        param1_01 = func_ii_7048(param1_00,uVar6,0);
		        uVar10 = System_Action_BattlesWndButton__TypeInfo;
		        if ((param1_01 != 0) &&
		           (iVar3 = func_ii_1082(param1_01,System_Action_BattlesWndButton__TypeInfo), iVar3 == 0)) {
		          System_Activator__CreateInstance(param1_01,uVar10);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar3 = func_ii_4329(iVar7 + 0x28,iVar3,param1_00);
		        bVar1 = iVar3 != param1_00;
		        param1_00 = iVar3;
		      } while (bVar1);
		      iVar9 = iVar9 + 1;
		    } while (iVar9 < *(int *)(iVar4 + 0xc));
		  }
		  uVar2 = 0;
		  piVar8 = *(int **)(param1[2] + 0xc);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8 + 4) * 8 + iVar9 + 0x1e0);
		        goto code_r0x81d08e67;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x24);
		code_r0x81d08e67:
		  iVar9 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		  iVar4 = *(int *)(iVar9 + 0x14);
		  uVar10 = *(undefined4 *)(iVar4 + 0x20);
		  uVar6 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar6,param1,
		             Method_Gameplay_Battles_Controller_BattlesViewMediator_BossTotalNotificationNumChangedEvent__
		             ,0);
		  piVar8 = (int *)func_ii_7048(uVar10,uVar6,0);
		  iVar9 = System_Action_TypeInfo;
		  if (piVar8 == (int *)0x0) {
		    *(undefined4 *)(iVar4 + 0x20) = 0;
		  }
		  else if ((*piVar8 != System_Action_TypeInfo) ||
		          (*(int **)(iVar4 + 0x20) = piVar8, *piVar8 != iVar9)) {
		    System_Activator__CreateInstance(piVar8,iVar9);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar10 = *(undefined4 *)(param1[2] + 8);
		  uVar6 = unnamed_function_1417(iVar9);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar6,param1,
		             Method_Gameplay_Battles_Controller_BattlesViewMediator_HandleUserLevelChanged__,0);
		  Core_Data_UserData__add_OnUserLevelChangedEvent(uVar10,uVar6,0);
		  return;
		}
		*/

		}

		// Token: 0x06004C1F RID: 19487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C1F")]
		[Address(RVA = "0x9A63", Offset = "0x9A63", VA = "0x9A63")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Battles_Controller_BattlesViewMediator__ResetView(int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  uint uVar2;
		  uint uVar3;
		  int iVar4;
		  uint *puVar5;
		  int param1_00;
		  undefined4 param3;
		  int *piVar6;
		  int iVar7;
		  undefined4 uVar8;
		  int *piVar9;
		  undefined4 uVar10;
		  int iVar11;
		  undefined4 uVar12;
		  int iVar13;
		  int *piVar14;
		  undefined1 auStack_4 [4];
		  
		  iVar11 = 0;
		  if (DAT_ram_00a60991 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BattlesModel__BattlesEvents__BattlesController__BattlesWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_BattlesWndButton__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Battles_Controller_BattlesViewMediator_BossTotalNotificationNumChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Battles_Controller_BattlesViewMediator_BtnEventClickHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Battles_Controller_BattlesViewMediator_HandleUserLevelChanged__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Battles_View_ThemeDuelBattlesWndButton_TypeInfo);
		    DAT_ram_00a60991 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar2 = 0;
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + iVar7 + 0x1f8);
		        goto code_r0x81d09170;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x81d09170:
		  iVar7 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		  iVar13 = **(int **)(iVar7 + 0x14);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(iVar13 + 0x100) * 4))
		                    (*(int **)(iVar7 + 0x14),*(undefined4 *)(iVar13 + 0x104));
		  uVar8 = *(undefined4 *)(iVar7 + 0x28);
		  uVar2 = 0;
		  piVar6 = *(int **)(param1[2] + 0xc);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + iVar7 + 0x288);
		        goto code_r0x81d09214;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x81d09214:
		  iVar7 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		  uVar2 = Gameplay_ThemeDuelState_View_Balance_ThemeDuelBalanceView___ctor
		                    (*(undefined4 *)(iVar7 + 0x14),0);
		  iVar7 = *param1;
		  iVar13 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x158) * 4))
		                     (param1,*(undefined4 *)(iVar7 + 0x15c));
		  iVar13 = *(int *)(iVar13 + 0x3c);
		  if (0 < *(int *)(iVar13 + 0xc)) {
		    do {
		      piVar6 = *(int **)(iVar13 + iVar11 * 4 + 0x10);
		      uVar12 = unnamed_function_1417(System_Action_BattlesWndButton__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar12,param1,
		                 Method_Gameplay_Battles_Controller_BattlesViewMediator_BtnEventClickHandler__,0);
		      if (DAT_ram_00a60971 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_BattlesWndButton__TypeInfo);
		        DAT_ram_00a60971 = '\x01';
		      }
		      iVar7 = piVar6[10];
		      do {
		        iVar4 = 0;
		        param1_00 = UnityEngine_UI_Image__set_sprite(iVar7,uVar12,0);
		        uVar10 = System_Action_BattlesWndButton__TypeInfo;
		        if ((param1_00 != 0) &&
		           (iVar4 = func_ii_1082(param1_00,System_Action_BattlesWndButton__TypeInfo), iVar4 == 0)) {
		          System_Activator__CreateInstance(param1_00,uVar10);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar4 = func_ii_4329(piVar6 + 10,iVar4,iVar7);
		        bVar1 = iVar4 != iVar7;
		        iVar7 = iVar4;
		      } while (bVar1);
		      iVar7 = piVar6[8];
		      if (iVar7 < 3) {
		        if (iVar7 == 1) {
		          iVar7 = piVar6[6];
		          uVar10 = *(undefined4 *)(param1[2] + 8);
		          uVar12 = Gameplay_Accounts_Model_Data_BattleAccount__GetArenaEqualCost(uVar8,uVar10,0);
		          if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Core_Money_Money_TypeInfo);
		          }
		          uVar12 = Core_Money_Money__op_Explicit(uVar12,0);
		          UI_Price_Price__SetColor(iVar7,uVar10,uVar12,0);
		        }
		        else if (iVar7 == 2) {
		          iVar7 = piVar6[6];
		          uVar10 = *(undefined4 *)(param1[2] + 8);
		          uVar12 = Gameplay_Accounts_Model_Data_BattleAccount__Init(uVar8,uVar10,0);
		          if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Core_Money_Money_TypeInfo);
		          }
		          uVar12 = Core_Money_Money__op_Explicit(uVar12,0);
		          UI_Price_Price__SetColor(iVar7,uVar10,uVar12,0);
		        }
		      }
		      else if (iVar7 == 8) {
		        uVar12 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                           (piVar6,0);
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar12,uVar2 ^ 1,0);
		      }
		      else if (iVar7 == 9) {
		        iVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (piVar6,0);
		        if (uVar2 == 0) {
		          Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                    (iVar7,0,0);
		        }
		        else {
		          Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                    (iVar7,1,0);
		          piVar9 = *(int **)(param1[2] + 0xc);
		          iVar7 = *piVar9;
		          if (*(ushort *)(iVar7 + 0xb6) != 0) {
		            uVar3 = 0;
		            do {
		              piVar14 = (int *)(*(int *)(iVar7 + 0x58) + uVar3 * 8);
		              if (Core_Gameplay_IGame_TypeInfo == *piVar14) {
		                puVar5 = (uint *)(piVar14[1] * 8 + iVar7 + 0x288);
		                goto code_r0x81d093c0;
		              }
		              uVar3 = uVar3 + 1;
		            } while (*(ushort *)(iVar7 + 0xb6) != uVar3);
		          }
		          puVar5 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x81d093c0:
		          iVar7 = (**(code **)((ulonglong)*puVar5 * 4))(piVar9,puVar5[1]);
		          uVar12 = *(undefined4 *)(iVar7 + 0x14);
		          piVar9 = *(int **)(param1[2] + 0xc);
		          iVar7 = *piVar9;
		          if (*(ushort *)(iVar7 + 0xb6) != 0) {
		            uVar3 = 0;
		            do {
		              piVar14 = (int *)(*(int *)(iVar7 + 0x58) + uVar3 * 8);
		              if (Core_Gameplay_IGame_TypeInfo == *piVar14) {
		                puVar5 = (uint *)(piVar14[1] * 8 + iVar7 + 0x1f8);
		                goto code_r0x81d09447;
		              }
		              uVar3 = uVar3 + 1;
		            } while (*(ushort *)(iVar7 + 0xb6) != uVar3);
		          }
		          puVar5 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x81d09447:
		          iVar7 = (**(code **)((ulonglong)*puVar5 * 4))(piVar9,puVar5[1]);
		          iVar4 = **(int **)(iVar7 + 0x14);
		          iVar7 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x100) * 4))
		                            (*(int **)(iVar7 + 0x14),*(undefined4 *)(iVar4 + 0x104));
		          uVar10 = *(undefined4 *)(iVar7 + 0x28);
		          piVar9 = *(int **)(param1[2] + 0xc);
		          iVar7 = *piVar9;
		          if (*(ushort *)(iVar7 + 0xb6) != 0) {
		            uVar3 = 0;
		            do {
		              piVar14 = (int *)(*(int *)(iVar7 + 0x58) + uVar3 * 8);
		              if (Core_Gameplay_IGame_TypeInfo == *piVar14) {
		                puVar5 = (uint *)(piVar14[1] * 8 + iVar7 + 0x288);
		                goto code_r0x81d094e7;
		              }
		              uVar3 = uVar3 + 1;
		            } while (*(ushort *)(iVar7 + 0xb6) != uVar3);
		          }
		          puVar5 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x81d094e7:
		          iVar7 = (**(code **)((ulonglong)*puVar5 * 4))(piVar9,puVar5[1]);
		          iVar7 = Gameplay_Accounts_Model_Data_BattleAccount__GetPartyCombatCost
		                            (uVar10,*(undefined4 *)(iVar7 + 0x14),0);
		          iVar4 = piVar6[6];
		          uVar10 = *(undefined4 *)(param1[2] + 8);
		          if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Core_Money_Money_TypeInfo);
		          }
		          param3 = Core_Money_Money__op_Explicit(iVar7,0);
		          UI_Price_Price__SetColor(iVar4,uVar10,param3,0);
		          if (*piVar6 == Gameplay_Battles_View_ThemeDuelBattlesWndButton_TypeInfo) {
		            iVar7 = piVar6[0xb];
		            uVar10 = Gameplay_ThemeDuelState_Model_ThemeDuelStateModel__get_HasCurrentThemeDuel
		                               (uVar12,0);
		            uVar10 = Core_Extensions_Dict_ThemeDuelDicExt__GetIcon64AssetId(uVar10,0);
		            Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		                      (iVar7,uVar10,
		                       Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		                      );
		            piVar6 = (int *)piVar6[0xc];
		            uVar12 = Gameplay_ThemeDuelState_Model_ThemeDuelStateModel__get_HasCurrentThemeDuel
		                               (uVar12,0);
		            uVar12 = Core_Extensions_Dict_ThemeDuelDicExt__GetImgForRulesAssetId(uVar12,0);
		            iVar7 = *piVar6;
		            (**(code **)((ulonglong)*(uint *)(iVar7 + 0x2d0) * 4))
		                      (piVar6,uVar12,*(undefined4 *)(iVar7 + 0x2d4));
		          }
		        }
		      }
		      iVar11 = iVar11 + 1;
		    } while (iVar11 < *(int *)(iVar13 + 0xc));
		  }
		  Gameplay_Battles_Controller_BattlesViewMediator___ctor(param1,iVar7);
		  piVar6 = *(int **)(param1[2] + 0xc);
		  iVar11 = *piVar6;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8 + 4) * 8 + iVar11 + 0x1e0);
		        goto code_r0x81d096c1;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x24);
		code_r0x81d096c1:
		  iVar11 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		  iVar7 = *(int *)(iVar11 + 0x14);
		  uVar12 = *(undefined4 *)(iVar7 + 0x20);
		  uVar8 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar8,param1,
		             Method_Gameplay_Battles_Controller_BattlesViewMediator_BossTotalNotificationNumChangedEvent__
		             ,0);
		  piVar6 = (int *)UnityEngine_UI_Image__set_sprite(uVar12,uVar8,0);
		  iVar11 = System_Action_TypeInfo;
		  if (piVar6 == (int *)0x0) {
		    *(undefined4 *)(iVar7 + 0x20) = 0;
		  }
		  else if ((*piVar6 != System_Action_TypeInfo) ||
		          (*(int **)(iVar7 + 0x20) = piVar6, *piVar6 != iVar11)) {
		    System_Activator__CreateInstance(piVar6,iVar11);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar12 = *(undefined4 *)(param1[2] + 8);
		  iVar7 = 0;
		  uVar8 = unnamed_function_1417(iVar11);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar8,param1,
		             Method_Gameplay_Battles_Controller_BattlesViewMediator_HandleUserLevelChanged__,0);
		  Core_Data_UserData__remove_UserSkillsChangedEvent(uVar12,uVar8,0);
		  if (DAT_ram_00a60992 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BattlesModel__BattlesEvents__BattlesController__BattlesWindow__get_Model__
		              );
		    DAT_ram_00a60992 = '\x01';
		  }
		  iVar11 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                     (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar11 = *(int *)(iVar11 + 0x3c);
		  if (0 < *(int *)(iVar11 + 0xc)) {
		    do {
		      iVar13 = *(int *)(iVar11 + iVar7 * 4 + 0x10);
		      uVar8 = Gameplay_Battles_Model_BattlesModel__set_NotificationCount
		                        (param1[2],*(undefined4 *)(iVar13 + 0x10),auStack_4,iVar7);
		      uVar12 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                         (*(undefined4 *)(iVar13 + 0x24),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar12,uVar8,0);
		      iVar7 = iVar7 + 1;
		    } while (iVar7 < *(int *)(iVar11 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004C20 RID: 19488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C20")]
		[Address(RVA = "0x9A64", Offset = "0x9A64", VA = "0x9A64")]
		private void SetupView()
		{
		}

		// Token: 0x06004C21 RID: 19489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C21")]
		[Address(RVA = "0x9A65", Offset = "0x9A65", VA = "0x9A65")]
		private void HandleUserLevelChanged()
		{
		/* --- GHIDRA: HandleUserLevelChanged ---
		void Gameplay_Battles_Controller_BattlesViewMediator__HandleUserLevelChanged
		               (int *param1,undefined4 param2)
		
		{
		  int param4;
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int iVar2;
		  undefined1 auStack_4 [4];
		  
		  if (DAT_ram_00a60992 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BattlesModel__BattlesEvents__BattlesController__BattlesWindow__get_Model__
		              );
		    DAT_ram_00a60992 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = *(int *)(iVar1 + 0x3c);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    param4 = 0;
		    do {
		      iVar2 = *(int *)(iVar1 + param4 * 4 + 0x10);
		      param2_00 = Gameplay_Battles_Model_BattlesModel__set_NotificationCount
		                            (param1[2],*(undefined4 *)(iVar2 + 0x10),auStack_4,param4);
		      param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (*(undefined4 *)(iVar2 + 0x24),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (param1_00,param2_00,0);
		      param4 = param4 + 1;
		    } while (param4 < *(int *)(iVar1 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004C22 RID: 19490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C22")]
		[Address(RVA = "0x9A66", Offset = "0x9A66", VA = "0x9A66")]
		private void ValidateLocks()
		{
		/* --- GHIDRA: ValidateLocks ---
		void Gameplay_Battles_Controller_BattlesViewMediator__ValidateLocks
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 param3_00;
		  uint *puVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a60993 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BattlesModel__BattlesEvents__BattlesController__BattlesWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Last_RestrictionInfo___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2515);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25096);
		    DAT_ram_00a60993 = '\x01';
		  }
		  local_4 = 0;
		  local_10 = 0;
		  iVar2 = Gameplay_Battles_Model_BattlesModel__set_NotificationCount
		                    (param1[2],*(undefined4 *)(param2 + 0x10),&local_4,param2);
		  if (iVar2 == 0) {
		    iVar2 = *(int *)(param2 + 0x20);
		    if (iVar2 == 1) {
		      piVar5 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                                (param1,*(undefined4 *)(*param1 + 0x14c));
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x100) * 4))
		                        (piVar5,*(undefined4 *)(*piVar5 + 0x104));
		      iVar2 = Gameplay_ArenaCombat_ArenaCombat__TryRun(*(undefined4 *)(iVar2 + 0xc),1,1,0,0);
		      if (iVar2 != 0) {
		        uVar6 = Unity_Properties_PropertyMember___ctor
		                          (4,Core_Gameplay_IGame_TypeInfo,*(undefined4 *)(param1[2] + 0xc));
		        uVar6 = Unity_Properties_PropertyMember___ctor(5,Core_Application_IApp_TypeInfo,uVar6);
		        UI_Windows_PopupController__Close(uVar6,2,0);
		      }
		    }
		    else if (iVar2 == 2) {
		      piVar5 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                                (param1,*(undefined4 *)(*param1 + 0x14c));
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x100) * 4))
		                        (piVar5,*(undefined4 *)(*piVar5 + 0x104));
		      iVar2 = Gameplay_ArenaCombat_ArenaCombat__TryRun(*(undefined4 *)(iVar2 + 0xc),2,1,0,0);
		      if (iVar2 != 0) {
		        uVar6 = Unity_Properties_PropertyMember___ctor
		                          (4,Core_Gameplay_IGame_TypeInfo,*(undefined4 *)(param1[2] + 0xc));
		        uVar6 = Unity_Properties_PropertyMember___ctor(5,Core_Application_IApp_TypeInfo,uVar6);
		        UI_Windows_PopupController__Close(uVar6,2,0);
		      }
		    }
		    else if (iVar2 == 3) {
		      iVar2 = *param1;
		      uVar6 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x148) * 4))
		                        (param1,*(undefined4 *)(iVar2 + 0x14c));
		      Gameplay_Battles_Controller_BattlesController__TryRunArenaEqualPower(uVar6,iVar2);
		    }
		    else if (iVar2 == 4) {
		      iVar2 = *param1;
		      uVar6 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x148) * 4))
		                        (param1,*(undefined4 *)(iVar2 + 0x14c));
		      Gameplay_Battles_Controller_BattlesController__ShowArenaTournamentAdepts(uVar6,iVar2);
		    }
		    else if (iVar2 == 5) {
		      piVar5 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                                (param1,*(undefined4 *)(*param1 + 0x14c));
		      if (DAT_ram_00a6097b == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		        DAT_ram_00a6097b = '\x01';
		      }
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x100) * 4))
		                        (piVar5,*(undefined4 *)(*piVar5 + 0x104));
		      piVar5 = *(int **)(iVar2 + 0xc);
		      iVar2 = *piVar5;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x1e0);
		            goto code_r0x81d09f39;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x24);
		code_r0x81d09f39:
		      uVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		      Core_Gameplay_Managers_BossManager__get_Name(uVar6,0);
		    }
		    else if (iVar2 == 6) {
		      piVar5 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                                (param1,*(undefined4 *)(*param1 + 0x14c));
		      if (DAT_ram_00a6097e == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		        DAT_ram_00a6097e = '\x01';
		      }
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x100) * 4))
		                        (piVar5,*(undefined4 *)(*piVar5 + 0x104));
		      piVar5 = *(int **)(iVar2 + 0xc);
		      iVar2 = *piVar5;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 600);
		            goto code_r0x81d0a155;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x33);
		code_r0x81d0a155:
		      uVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		      Core_Gameplay_Managers_WorldAxisManager___ctor(uVar6,0);
		    }
		    else if (iVar2 == 7) {
		      iVar2 = *param1;
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0x148) * 4))(param1,*(undefined4 *)(iVar2 + 0x14c));
		      Gameplay_Battles_Controller_BattlesController__ShowBosses(iVar2,iVar2);
		    }
		    else if (iVar2 == 8) {
		      iVar2 = *param1;
		      uVar6 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x148) * 4))
		                        (param1,*(undefined4 *)(iVar2 + 0x14c));
		      Gameplay_Battles_Controller_BattlesController__ShowArenaTournamentGladiators(uVar6,iVar2);
		    }
		    else {
		      if (iVar2 != 9) {
		        uVar6 = unnamed_function_2232(&System_NotSupportedException_TypeInfo);
		        uVar6 = unnamed_function_1417(uVar6);
		        func_ii_20706(uVar6,0);
		        uVar7 = unnamed_function_2232
		                          (&
		                           Method_Gameplay_Battles_Controller_BattlesViewMediator_BtnEventClickHandler__
		                          );
		        func_ii_1050(uVar6,uVar7);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      uVar1 = 0;
		      piVar5 = *(int **)(param1[2] + 0xc);
		      iVar2 = *piVar5;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x288);
		            goto code_r0x81d0a1e4;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x81d0a1e4:
		      iVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		      iVar2 = Gameplay_ThemeDuelState_View_Balance_ThemeDuelBalanceView___ctor
		                        (*(undefined4 *)(iVar2 + 0x14),0);
		      uVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		      if (iVar2 == 0) {
		        Gameplay_Battles_Controller_BattlesController__ShowArenaTournamentGladiators(uVar6,0);
		      }
		      else {
		        Gameplay_Battles_Controller_BattlesController__ShowVortex(iVar2,iVar2);
		      }
		    }
		  }
		  else {
		    uVar1 = 0;
		    piVar5 = *(int **)(param1[2] + 0xc);
		    iVar2 = *piVar5;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe0);
		          goto code_r0x81d09d15;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81d09d15:
		    piVar5 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		    uVar1 = 0;
		    iVar2 = *piVar5;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xf0);
		          goto code_r0x81d09d97;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Core_Application_IApp_TypeInfo,6);
		code_r0x81d09d97:
		    uVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar7 = func_ii_7508(StringLiteral_2515,1,0,1,0,0,0,0);
		    iVar2 = Mono_Security_ASN1Convert__ToOid
		                      (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		    iVar3 = System_Linq_Enumerable__IntersectIterator___Il2CppFullySharedGenericType_
		                      (local_4,Method_System_Linq_Enumerable_Last_RestrictionInfo___);
		    local_10 = *(undefined8 *)(iVar3 + 0x10);
		    param3_00 = UnityEngine_GameObject__SetActive(&local_10,0);
		    local_18 = 0;
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_18,StringLiteral_25096,param3_00,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar2 + 0x10) = local_18;
		    uVar7 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar7,iVar2,0);
		    Core_Application_App__get_ToastController(uVar6,1,uVar7,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004C23 RID: 19491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C23")]
		[Address(RVA = "0x9A67", Offset = "0x9A67", VA = "0x9A67")]
		private void BtnEventClickHandler(BattlesWndButton btn)
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Battles_Controller_BattlesViewMediator__set_View(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  int iVar6;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a6098d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BattlesModel__BattlesEvents__BattlesController__BattlesWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ThemeDuelDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Battles_Controller_BattlesViewMediator_OnCurrentThemeDuelChanged__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a6098d = '\x01';
		  }
		  param1_00 = *(int **)(*(int *)(param1 + 8) + 0xc);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x288);
		        goto code_r0x81d08fd1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x81d08fd1:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar6 = *(int *)(iVar5 + 0x18);
		  param1_01 = *(undefined4 *)(iVar6 + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_ThemeDuelDic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Battles_Controller_BattlesViewMediator_OnCurrentThemeDuelChanged__,0);
		  iVar5 = UnityEngine_UI_Image__set_sprite(param1_01,uVar3,0);
		  uVar3 = System_Action_ThemeDuelDic__TypeInfo;
		  if (iVar5 == 0) {
		    *(undefined4 *)(iVar6 + 0x18) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar5,System_Action_ThemeDuelDic__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar6 + 0x18) = iVar4;
		    uVar3 = System_Action_ThemeDuelDic__TypeInfo;
		    iVar6 = func_ii_1082(iVar5,System_Action_ThemeDuelDic__TypeInfo);
		    if (iVar6 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar5,uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar5,uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
