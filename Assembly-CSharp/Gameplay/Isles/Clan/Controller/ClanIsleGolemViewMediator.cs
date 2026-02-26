using System;
using Gameplay.Isles.Clan.Events;
using Gameplay.Isles.Clan.Model;
using Gameplay.Isles.Clan.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Isles.Clan.Controller
{
	// Token: 0x02000CF6 RID: 3318
	[Token(Token = "0x2000CF6")]
	public class ClanIsleGolemViewMediator : AbstractViewMediator<ClanIsleModel, ClanIsleEvents, ClanIsleController, ClanIsleGolemView>
	{
		// Token: 0x060050CA RID: 20682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050CA")]
		[Address(RVA = "0x9ED9", Offset = "0x9ED9", VA = "0x9ED9")]
		public ClanIsleGolemViewMediator(ClanIsleModel model, ClanIsleEvents events, ClanIsleController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_Clan_Controller_ClanIsleGolemViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58cca == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanIsleGolemView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Clan_Controller_ClanIsleGolemViewMediator_GolemStateChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Clan_Controller_ClanIsleGolemViewMediator_IsCurrentChangedEvent__
		              );
		    DAT_ram_00a58cca = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Isles_Clan_Controller_ClanIsleGolemViewMediator_IsCurrentChangedEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x24);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Isles_Clan_Controller_ClanIsleGolemViewMediator_GolemStateChangedEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x24) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x24) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Isles_Clan_Controller_ClanIsleGolemViewMediator_IsCurrentChangedEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x24);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Isles_Clan_Controller_ClanIsleGolemViewMediator_GolemStateChangedEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x24) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x24) = piVar4, *piVar4 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17001054 RID: 4180
		// (set) Token: 0x060050CB RID: 20683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001054")]
		public override ClanIsleEvents Events
		{
			[Token(Token = "0x60050CB")]
			[Address(RVA = "0x9EDA", Offset = "0x9EDA", VA = "0x9EDA", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060050CC RID: 20684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050CC")]
		[Address(RVA = "0x9EDB", Offset = "0x9EDB", VA = "0x9EDB")]
		private void IsCurrentChangedEvent()
		{
		/* --- GHIDRA: IsCurrentChangedEvent ---
		void Gameplay_Isles_Clan_Controller_ClanIsleGolemViewMediator__IsCurrentChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a58ccb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanIsleGolemView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_Clan_Controller_ClanIsleGolemViewMediator_ViewOnClickEvent__);
		    DAT_ram_00a58ccb = '\x01';
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar2,0);
		  if (iVar3 != 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Isles_Clan_Controller_ClanIsleGolemViewMediator_ViewOnClickEvent__,0)
		    ;
		    if (DAT_ram_00a58d1e == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		      DAT_ram_00a58d1e = '\x01';
		    }
		    iVar6 = *(int *)(iVar3 + 0x28);
		    do {
		      piVar4 = (int *)func_ii_7048(iVar6,uVar2,0);
		      if ((piVar4 != (int *)0x0) && (System_Action_TypeInfo != *piVar4)) {
		        System_Activator__CreateInstance(piVar4,System_Action_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar5 = func_ii_4329(iVar3 + 0x28,piVar4,iVar6);
		      bVar1 = iVar5 != iVar6;
		      iVar6 = iVar5;
		    } while (bVar1);
		  }
		  param1[5] = param2;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar2,0);
		  if (iVar3 != 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Isles_Clan_Controller_ClanIsleGolemViewMediator_ViewOnClickEvent__,0)
		    ;
		    if (DAT_ram_00a58d1d == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		      DAT_ram_00a58d1d = '\x01';
		    }
		    iVar6 = *(int *)(iVar3 + 0x28);
		    do {
		      piVar4 = (int *)UnityEngine_UI_Image__set_sprite(iVar6,uVar2,0);
		      if ((piVar4 != (int *)0x0) && (System_Action_TypeInfo != *piVar4)) {
		        System_Activator__CreateInstance(piVar4,System_Action_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar5 = func_ii_4329(iVar3 + 0x28,piVar4,iVar6);
		      bVar1 = iVar5 != iVar6;
		      iVar6 = iVar5;
		    } while (bVar1);
		    iVar6 = *param1;
		    iVar3 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x158) * 4))
		                      (param1,*(undefined4 *)(iVar6 + 0x15c));
		    AssetContent_GameAssetViewSpriteRenderer__get_Interactable(*(undefined4 *)(iVar3 + 0x2c),0,0);
		    Gameplay_Isles_Clan_Controller_ClanIsleGolemViewMediator__ViewOnClickEvent(param1,iVar6);
		    Gameplay_Isles_Clan_Controller_ClanIsleGolemViewMediator__set_View(param1,iVar6);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17001055 RID: 4181
		// (set) Token: 0x060050CD RID: 20685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001055")]
		public override ClanIsleGolemView View
		{
			[Token(Token = "0x60050CD")]
			[Address(RVA = "0x9EDC", Offset = "0x9EDC", VA = "0x9EDC", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060050CE RID: 20686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050CE")]
		[Address(RVA = "0x9EDD", Offset = "0x9EDD", VA = "0x9EDD")]
		private void ValidateGolemState()
		{
		/* --- GHIDRA: ValidateGolemState ---
		void Gameplay_Isles_Clan_Controller_ClanIsleGolemViewMediator__ValidateGolemState
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a58ccd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__TryOpenBuildingByType__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanIsleGolemView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58ccd = '\x01';
		  }
		  if (*(char *)(*(int *)(param1 + 8) + 0x18) == '\0') {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar3 = *param1_01;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x110);
		          goto code_r0x80f992ea;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80f992ea:
		    iVar3 = (**(code **)((ulonglong)*puVar2 * 4))
		                      (param1_01,CONCAT44(in_register_20000014,puVar2[1]));
		    param1_00 = Gameplay_World_Model_WorldModel__GetUserIsle
		                          (*(undefined4 *)(iVar3 + 0x14),
		                           *(undefined8 *)(*(int *)(param1 + 8) + 0x10),0);
		    Gameplay_Isles_Base_AbstractIsle_object__object__object__Int32Enum___SetIsCurrentIsle
		              (param1_00,3,
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__TryOpenBuildingByType__
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x060050CF RID: 20687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050CF")]
		[Address(RVA = "0x9EDE", Offset = "0x9EDE", VA = "0x9EDE")]
		private void ViewOnClickEvent()
		{
		/* --- GHIDRA: ViewOnClickEvent ---
		void Gameplay_Isles_Clan_Controller_ClanIsleGolemViewMediator__ViewOnClickEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58cce == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanIsleGolemView__get_Model__
		              );
		    DAT_ram_00a58cce = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if ((iVar1 != 0) && (*(char *)(param1[2] + 0x2c) != '\0')) {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar2,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,1,0);
		    iVar1 = param1[2];
		    if (DAT_ram_00a58cb1 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__ContainsKey__
		                );
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		      DAT_ram_00a58cb1 = '\x01';
		    }
		    iVar4 = *(int *)(iVar1 + 0x24);
		    if (((iVar4 == 0) ||
		        (iVar4 = UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		                           (iVar4,3,
		                            Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__ContainsKey__
		                           ), iVar4 == 0)) ||
		       (piVar3 = (int *)System_Collections_Generic_List_object___get_Item
		                                  (*(undefined4 *)(iVar1 + 0x24),3,
		                                   Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                                  ), piVar3 == (int *)0x0)) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar2 = 0;
		    }
		    else {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		                        (piVar3,*(undefined4 *)(*piVar3 + 0x104));
		    }
		    AssetContent_GameAssetViewSpriteRenderer__get_AssetId(*(undefined4 *)(iVar1 + 0x24),uVar2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060050D0 RID: 20688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050D0")]
		[Address(RVA = "0x9EDF", Offset = "0x9EDF", VA = "0x9EDF")]
		private void RenderView()
		{
		/* --- GHIDRA: RenderView ---
		void Gameplay_Isles_Clan_Controller_ClanIsleGolemViewMediator__RenderView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58ccf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanIsleGolemView__Dispose__
		              );
		    DAT_ram_00a58ccf = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  AssetContent_GameAssetViewSpriteRenderer__get_AssetId(*(undefined4 *)(iVar1 + 0x24),0,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  AssetContent_GameAssetViewSpriteRenderer__get_AssetId(*(undefined4 *)(iVar1 + 0x2c),0,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanIsleGolemView__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060050D1 RID: 20689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050D1")]
		[Address(RVA = "0x9EE0", Offset = "0x9EE0", VA = "0x9EE0", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Isles_Clan_Controller_ClanIsleGolemViewMediator__Dispose
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Isles_Clan_Controller_ClanIsleGolemViewMediator__set_View(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060050D2 RID: 20690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050D2")]
		[Address(RVA = "0x9EE1", Offset = "0x9EE1", VA = "0x9EE1")]
		private void GolemStateChangedEvent()
		{
		/* --- GHIDRA: GolemStateChangedEvent ---
		void Gameplay_Isles_Clan_Controller_ClanIsleGolemViewMediator__GolemStateChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58cd0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__BaseIsleEvents__ClanIsleController__ClanIsleView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58cd0 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x80f99492;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80f99492:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,CONCAT44(in_register_20000014,puVar2[1]));
		  piVar3 = (int *)Gameplay_World_Model_WorldModel__GetUserIsle
		                            (*(undefined4 *)(iVar4 + 0x14),
		                             *(undefined8 *)(*(int *)(param1 + 8) + 0x10),0);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x118) * 4))
		            (piVar3,param2,*(undefined4 *)(*piVar3 + 0x11c));
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Isles_Clan_Controller_ClanIsleGolemViewMediator__set_Events
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Isles_Clan_Controller_ClanIsleGolemViewMediator__ViewOnClickEvent(param1,param1);
		  Gameplay_Isles_Clan_Controller_ClanIsleGolemViewMediator__set_View(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Isles_Clan_Controller_ClanIsleGolemViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  float fVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a58ccc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanIsleGolemView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58ccc = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if ((iVar2 != 0) && (*(char *)(param1[2] + 0x2c) != '\0')) {
		    iVar2 = *(int *)(param1[2] + 0x34);
		    if ((iVar2 != 0) && (fVar3 = func_ii_7103(iVar2,0), 0.0 < fVar3)) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      param1_00 = *(undefined4 *)(iVar2 + 0x2c);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      uVar1 = 0;
		      param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar2 = *param1_01;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x178);
		            goto code_r0x80f98ec8;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f98ec8:
		      uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(param1_01,puVar4[1]);
		      uVar5 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar5,0);
		      uVar5 = Core_Extensions_Dict_DictExt__GetCult
		                        (uVar5,*(undefined4 *)(*(int *)(*(int *)(param1[2] + 0x30) + 0x1c) + 0x1c),0
		                        );
		      uVar5 = Core_Extensions_Dict_ClanCultDicExt__GetIslePreviewAssetId(uVar5,0);
		      AssetContent_GameAssetViewSpriteRenderer__get_AssetId(param1_00,uVar5,0);
		      return;
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    AssetContent_GameAssetViewSpriteRenderer__get_AssetId(*(undefined4 *)(iVar2 + 0x2c),0,0);
		  }
		  return;
		}
		*/

}
