using System;
using Il2CppDummyDll;
using MVC;
using UI.Windows.Buildings;

namespace Gameplay.Cave.Controller
{
	// Token: 0x02000B35 RID: 2869
	[Token(Token = "0x2000B35")]
	public class CaveWindowMediator : AbstractViewMediator<CaveModel, CaveEvents, CaveController, CaveWindow>
	{
		// Token: 0x060045AB RID: 17835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045AB")]
		[Address(RVA = "0x944D", Offset = "0x944D", VA = "0x944D")]
		public CaveWindowMediator(CaveModel model, CaveEvents events, CaveController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Cave_Controller_CaveWindowMediator___ctor(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57973 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CaveModel__CaveEvents__CaveController__CaveWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Cave_Controller_CaveWindowMediator_CaveStateChangedEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Cave_Controller_CaveWindowMediator_CloseWindow__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Cave_Controller_CaveWindowMediator_MonsterStatusChangedEvent__);
		    DAT_ram_00a57973 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Cave_Controller_CaveWindowMediator_CaveStateChangedEvent__,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,Method_Gameplay_Cave_Controller_CaveWindowMediator_CloseWindow__,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Cave_Controller_CaveWindowMediator_MonsterStatusChangedEvent__,0);
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
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Cave_Controller_CaveWindowMediator_CaveStateChangedEvent__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,Method_Gameplay_Cave_Controller_CaveWindowMediator_CloseWindow__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Cave_Controller_CaveWindowMediator_MonsterStatusChangedEvent__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1))
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

		// Token: 0x17000DBC RID: 3516
		// (set) Token: 0x060045AC RID: 17836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DBC")]
		public override CaveEvents Events
		{
			[Token(Token = "0x60045AC")]
			[Address(RVA = "0x944E", Offset = "0x944E", VA = "0x944E", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060045AD RID: 17837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045AD")]
		[Address(RVA = "0x944F", Offset = "0x944F", VA = "0x944F")]
		private void MonsterStatusChangedEvent()
		{
		/* --- GHIDRA: MonsterStatusChangedEvent ---
		void Gameplay_Cave_Controller_CaveWindowMediator__MonsterStatusChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  uint param2_00;
		  
		  if (DAT_ram_00a57975 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CaveModel__CaveEvents__CaveController__CaveWindow__get_Model__
		              );
		    DAT_ram_00a57975 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Windows_Buildings_CaveWindow__set_ResourceAmount
		            (uVar1,(uint)(*(int *)(param1[2] + 0x14) == 0),0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x60),0);
		  if (*(char *)(param1[2] + 0x1c) == '\0') {
		    param2_00 = (uint)(*(int *)(param1[2] + 0x14) != 0);
		  }
		  else {
		    param2_00 = 0;
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,param2_00,0);
		  if (*(char *)(param1[2] + 0x1c) == '\0') {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar2 + 100),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    if (DAT_ram_00a57977 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_UI_Windows_ClosableBaseWindow_CaveWindowArgs__get_BackButton__);
		      Mono_Security_ASN1__get_Item
		                (&Method_UI_Windows_WindowWhitCloseButton_CaveWindowArgs__get_CloseButton__);
		      DAT_ram_00a57977 = '\x01';
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar2 + 0x34),1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar2 + 0x38),1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar2 + 0x68),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    if (*(char *)(param1[2] + 0x1c) == '\0') {
		      if (*(int *)(param1[2] + 0x14) != 0) {
		        Gameplay_Cave_Controller_CaveWindowMediator__RenderRewards(param1,param1);
		        Gameplay_Cave_Controller_CaveWindowMediator__HideMonsterWiki(param1,param1);
		        return;
		      }
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar2 + 0x68),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar1,0,0);
		      Gameplay_Cave_Controller_CaveWindowMediator__OnChestClicked(param1,param1);
		      return;
		    }
		  }
		  Gameplay_Cave_Controller_CaveWindowMediator__RenderRewards(param1,param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Horde_View_HordeView__remove_RequestHordeInfoEvent
		            (*(undefined4 *)(iVar2 + 100),
		             *(undefined4 *)(*(int *)(*(int *)(param1[2] + 0x14) + 8) + 0xc),0);
		  return;
		}
		*/

		}

		// Token: 0x060045AE RID: 17838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045AE")]
		[Address(RVA = "0x9450", Offset = "0x9450", VA = "0x9450")]
		private void CaveStateChangedEvent()
		{
		/* --- GHIDRA: CaveStateChangedEvent ---
		void Gameplay_Cave_Controller_CaveWindowMediator__CaveStateChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57976 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CaveModel__CaveEvents__CaveController__CaveWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CaveModel__CaveEvents__CaveController__CaveWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Cave_Controller_CaveWindowMediator_AttackButtonClickHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Cave_Controller_CaveWindowMediator_KickButtonClickHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Cave_Controller_CaveWindowMediator_OnChestClicked__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Cave_Controller_CaveWindowMediator_OnSearchInCaveClicked__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57976 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x44) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Cave_Controller_CaveWindowMediator_OnSearchInCaveClicked__,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x58) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,Method_Gameplay_Cave_Controller_CaveWindowMediator_OnChestClicked__,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x60) + 0x18) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Cave_Controller_CaveWindowMediator_AttackButtonClickHandler__,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x60) + 0x1c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Cave_Controller_CaveWindowMediator_KickButtonClickHandler__,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 100) + 0x20) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Cave_Controller_CaveWindowMediator_KickButtonClickHandler__,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x44) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Cave_Controller_CaveWindowMediator_OnSearchInCaveClicked__,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x58) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,Method_Gameplay_Cave_Controller_CaveWindowMediator_OnChestClicked__,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x60) + 0x18) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Cave_Controller_CaveWindowMediator_AttackButtonClickHandler__,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x60) + 0x1c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Cave_Controller_CaveWindowMediator_KickButtonClickHandler__,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 100) + 0x20) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Cave_Controller_CaveWindowMediator_KickButtonClickHandler__,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 100);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Horde_View_HordeView__OnDestroy(uVar3,uVar1,param1[2],0);
		    if (DAT_ram_00a57977 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_UI_Windows_ClosableBaseWindow_CaveWindowArgs__get_BackButton__);
		      Mono_Security_ASN1__get_Item
		                (&Method_UI_Windows_WindowWhitCloseButton_CaveWindowArgs__get_CloseButton__);
		      DAT_ram_00a57977 = '\x01';
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar2 + 0x34),0,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar2 + 0x38),0,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000DBD RID: 3517
		// (set) Token: 0x060045AF RID: 17839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DBD")]
		public override CaveWindow View
		{
			[Token(Token = "0x60045AF")]
			[Address(RVA = "0x9451", Offset = "0x9451", VA = "0x9451", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060045B0 RID: 17840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B0")]
		[Address(RVA = "0x9452", Offset = "0x9452", VA = "0x9452")]
		private void EnableExitButtons(bool enable)
		{
		/* --- GHIDRA: EnableExitButtons ---
		void Gameplay_Cave_Controller_CaveWindowMediator__EnableExitButtons(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a57978 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CaveModel__CaveEvents__CaveController__CaveWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57978 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x1f8);
		        goto code_r0x80e0a7a9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x80e0a7a9:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar7 = **(int **)(iVar5 + 0x14);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x100) * 4))
		                    (*(int **)(iVar5 + 0x14),*(undefined4 *)(iVar7 + 0x104));
		  uVar6 = *(undefined4 *)(iVar5 + 0x28);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80e0a871;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e0a871:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar5 = func_ii_7112(uVar3,0);
		  uVar3 = *(undefined4 *)(iVar5 + 0x78);
		  uVar6 = Gameplay_Accounts_Model_Data_BattleAccount__GetMonsterAttackCost
		                    (uVar6,*(undefined4 *)(*(int *)(param1[2] + 0x14) + 8),0);
		  iVar5 = Core_Errors_Expected_ExpectedBillingErrors__GetErrorCode(uVar3,uVar6,0);
		  if (iVar5 != 0) {
		    iVar5 = *param1;
		    uVar6 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x148) * 4))
		                      (param1,*(undefined4 *)(iVar5 + 0x14c));
		    Gameplay_Cave_CaveController__AttackMonster(uVar6,iVar5);
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
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x220);
		          goto code_r0x80e0a95b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x80e0a95b:
		    iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    Gameplay_Inventory_View_EquipmentSlotView__set_ArtifactData(*(undefined4 *)(iVar5 + 0x18),8,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060045B1 RID: 17841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B1")]
		[Address(RVA = "0x9453", Offset = "0x9453", VA = "0x9453")]
		private void KickButtonClickHandler()
		{
		/* --- GHIDRA: KickButtonClickHandler ---
		void Gameplay_Cave_Controller_CaveWindowMediator__KickButtonClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57979 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CaveModel__CaveEvents__CaveController__CaveWindow__get_Model__
		              );
		    DAT_ram_00a57979 = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Cave_CaveController__OnGetCaveInfo(param1_00,param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060045B2 RID: 17842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B2")]
		[Address(RVA = "0x9454", Offset = "0x9454", VA = "0x9454")]
		private void AttackButtonClickHandler()
		{
		/* --- GHIDRA: AttackButtonClickHandler ---
		void Gameplay_Cave_Controller_CaveWindowMediator__AttackButtonClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Cave_CaveController__HandleStop(param1_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x060045B3 RID: 17843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B3")]
		[Address(RVA = "0x9455", Offset = "0x9455", VA = "0x9455")]
		private void OnSearchInCaveClicked()
		{
		/* --- GHIDRA: OnSearchInCaveClicked ---
		void Gameplay_Cave_Controller_CaveWindowMediator__OnSearchInCaveClicked
		               (int *param1,undefined4 param2)
		
		{
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))(param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Cave_CaveController__HandleMonsterKickService(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060045B4 RID: 17844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B4")]
		[Address(RVA = "0x9456", Offset = "0x9456", VA = "0x9456")]
		private void OnChestClicked()
		{
		/* --- GHIDRA: OnChestClicked ---
		void Gameplay_Cave_Controller_CaveWindowMediator__OnChestClicked(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *param1_00;
		  int iVar6;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5797a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CaveModel__CaveEvents__CaveController__CaveWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Sound_Control_IGameAudio_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RewardInfo__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RewardInfo__get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Cave_RewardBehaviourManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_47);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4120);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4121);
		    DAT_ram_00a5797a = '\x01';
		  }
		  iVar5 = *(int *)(param1[2] + 0xc);
		  if ((iVar5 == 0) || (*(int *)(iVar5 + 0xc) < 1)) {
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UI_Windows_Buildings_CaveWindow__set_ResourceText(uVar3,0,0);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UI_Windows_Buildings_CaveWindow__get_ResourceImageAssetId(uVar3,0,0);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = func_ii_7508(StringLiteral_4120,1,0,1,0,0,0,0);
		    UI_Windows_Buildings_CaveWindow__get_ResourceText(uVar3,uVar4,0);
		  }
		  else {
		    uVar3 = System_Linq_Enumerable__ToList_object_
		                      (iVar5,0,Method_System_Collections_Generic_List_RewardInfo__get_Item__);
		    if (*(int *)(Gameplay_Cave_RewardBehaviourManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Cave_RewardBehaviourManager_TypeInfo);
		    }
		    iVar5 = Gameplay_Cave_CaveController__FilterCaveArtifacts(uVar3,param1);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = func_ii_7508(StringLiteral_4121,1,0,1,0,0,0,0);
		    uVar4 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (uVar4,StringLiteral_47,*(undefined4 *)(iVar5 + 0x10),0);
		    UI_Windows_Buildings_CaveWindow__get_ResourceText(uVar3,uVar4,0);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UI_Windows_Buildings_CaveWindow__get_ResourceImageAssetId(uVar3,*(undefined4 *)(iVar5 + 0xc),0);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UI_Windows_Buildings_CaveWindow__set_ResourceText(uVar3,*(undefined4 *)(iVar5 + 0x14),0);
		    iVar5 = *(int *)(iVar5 + 0x18);
		    if (iVar5 != 0) {
		      param1_00 = *(int **)(param1[2] + 0x20);
		      iVar6 = *param1_00;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Gameplay_Sound_Control_IGameAudio_TypeInfo ==
		              *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		            goto code_r0x80e0a14b;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param1_00,Gameplay_Sound_Control_IGameAudio_TypeInfo,2);
		code_r0x80e0a14b:
		      (**(code **)((ulonglong)*puVar2 * 4))(param1_00,iVar5,puVar2[1]);
		    }
		  }
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar5 + 0x48);
		  uVar4 = *(undefined4 *)(param1[2] + 0x18);
		  param2_00 = *(undefined4 *)(param1[2] + 8);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar4 = Core_Money_Money__op_Explicit(uVar4,0);
		  UI_Price_Price__SetColor(uVar3,param2_00,uVar4,0);
		  return;
		}
		*/

		}

		// Token: 0x060045B5 RID: 17845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B5")]
		[Address(RVA = "0x9457", Offset = "0x9457", VA = "0x9457")]
		private void RenderRewards()
		{
		/* --- GHIDRA: RenderRewards ---
		void Gameplay_Cave_Controller_CaveWindowMediator__RenderRewards(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 param2_00;
		  int iVar5;
		  int *piVar6;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5797b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CaveModel__CaveEvents__CaveController__CaveWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    DAT_ram_00a5797b = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x68),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,1,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar2 + 0x68);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x178);
		        goto code_r0x80e09ac7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e09ac7:
		  param2_00 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,1);
		  local_4 = *(undefined4 *)(*(int *)(*(int *)(param1[2] + 0x14) + 8) + 0xc);
		  iVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  if ((iVar2 != 0) && (iVar5 = func_ii_1082(iVar2,*(undefined4 *)(*piVar6 + 0x20)), iVar5 == 0)) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar6[4] = iVar2;
		  UI_MonoBehaviourWithStates_Int32Enum___set_CurrentState(uVar3,param2_00,piVar6,0);
		  return;
		}
		*/

		}

		// Token: 0x060045B6 RID: 17846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B6")]
		[Address(RVA = "0x9458", Offset = "0x9458", VA = "0x9458")]
		private void ShowMonsterWiki()
		{
		/* --- GHIDRA: ShowMonsterWiki ---
		void Gameplay_Cave_Controller_CaveWindowMediator__ShowMonsterWiki(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x68),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x060045B7 RID: 17847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B7")]
		[Address(RVA = "0x9459", Offset = "0x9459", VA = "0x9459")]
		private void HideMonsterWiki()
		{
		/* --- GHIDRA: HideMonsterWiki ---
		void Gameplay_Cave_Controller_CaveWindowMediator__HideMonsterWiki(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 uVar8;
		  undefined4 param2_00;
		  undefined4 uVar9;
		  int iVar10;
		  
		  if (DAT_ram_00a5797c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CaveModel__CaveEvents__CaveController__CaveWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a5797c = '\x01';
		  }
		  iVar4 = *(int *)(param1[2] + 0x14);
		  iVar5 = *(int *)(*(int *)(iVar4 + 8) + 0x24);
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x1f8);
		        goto code_r0x80e09c2d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x80e09c2d:
		  iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  iVar10 = **(int **)(iVar7 + 0x14);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(iVar10 + 0x100) * 4))
		                    (*(int **)(iVar7 + 0x14),*(undefined4 *)(iVar10 + 0x104));
		  uVar8 = *(undefined4 *)(iVar7 + 0x28);
		  if ((iVar5 != 0) && (iVar5 = Core_Extensions_Dict_ResourceSetExt__GetDelta(iVar5,0), iVar5 == 0))
		  {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar9 = Gameplay_Isles_User_View_MonsterInfoView2__get_KickButton
		                      (*(undefined4 *)(iVar5 + 0x60),0);
		    param2_00 = *(undefined4 *)(param1[2] + 8);
		    uVar3 = Gameplay_Accounts_Model_Data_BattleAccount__GetArenaLevelCost
		                      (uVar8,*(undefined4 *)(iVar4 + 8),0);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    uVar3 = Core_Money_Money__op_Explicit(uVar3,0);
		    UI_Price_Price__SetColor(uVar9,param2_00,uVar3,0);
		  }
		  iVar5 = *(int *)(*(int *)(iVar4 + 8) + 0x2c);
		  if ((iVar5 != 0) && (iVar5 = Core_Extensions_Dict_ResourceSetExt__GetDelta(iVar5,0), iVar5 == 0))
		  {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar9 = Gameplay_Isles_User_View_MonsterInfoView2__get_AttackPrice
		                      (*(undefined4 *)(iVar5 + 0x60),0);
		    uVar3 = *(undefined4 *)(param1[2] + 8);
		    uVar8 = Gameplay_Accounts_Model_Data_BattleAccount__GetMonsterAttackCost
		                      (uVar8,*(undefined4 *)(*(int *)(param1[2] + 0x14) + 8),0);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    uVar8 = Core_Money_Money__op_Explicit(uVar8,0);
		    UI_Price_Price__SetColor(uVar9,uVar3,uVar8,0);
		  }
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar9 = *(undefined4 *)(iVar5 + 0x60);
		  uVar8 = Core_Extensions_Dict_AprDicExt__GetImageIsleAssetId
		                    (*(undefined4 *)(*(int *)(iVar4 + 0xc) + 0x10),0);
		  Gameplay_Isles_User_View_MonsterInfoView2__get_KickPrice(uVar9,uVar8,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar9 = *(undefined4 *)(iVar5 + 0x60);
		  uVar8 = Core_Data_MonsterData__get_KickPrice(iVar4,0);
		  Gameplay_Isles_User_View_MonsterInfoView__set_MonsterImageAssetId(uVar9,uVar8,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar9 = *(undefined4 *)(iVar5 + 0x60);
		  uVar8 = GAFInternal_Objects_GAFBakedObjectInternal__get_impl(iVar4,0);
		  Gameplay_Isles_User_View_MonsterInfoView__set_MonsterDescription(uVar9,uVar8,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar9 = *(undefined4 *)(iVar5 + 0x60);
		  uVar8 = Core_Data_MonsterData__GetDifficulty(iVar4,*(undefined4 *)(param1[2] + 8),0);
		  Gameplay_Isles_User_View_MonsterInfoView__set_MonsterLevel(uVar9,uVar8,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar9 = *(undefined4 *)(iVar5 + 0x60);
		  uVar8 = Gameplay_Boss_View_CaptainTab_BossInfoView__set_AttackOptions
		                    (*(undefined4 *)(iVar4 + 8),0);
		  Gameplay_Isles_User_View_MonsterInfoView__set_MonsterTitle(uVar9,uVar8,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar8 = *(undefined4 *)(iVar5 + 0x60);
		  uVar9 = *(undefined4 *)(param1[2] + 8);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar6;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x80e09ee4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e09ee4:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar9 = Core_Data_MonsterData__get_Level(iVar4,uVar9,uVar3,0);
		  Gameplay_Isles_User_View_MonsterInfoView__get_Rewards(uVar8,uVar9,0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar8 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar4 + 0x60) + 0x18),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar8,(uint)*(byte *)(param1[2] + 0x10),0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar8 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar4 + 0x60) + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar8,(uint)*(byte *)(param1[2] + 0x10),0);
		  return;
		}
		*/

		}

		// Token: 0x060045B8 RID: 17848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B8")]
		[Address(RVA = "0x945A", Offset = "0x945A", VA = "0x945A")]
		private void RenderMonster()
		{
		/* --- GHIDRA: RenderMonster ---
		void Gameplay_Cave_Controller_CaveWindowMediator__RenderMonster(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5797d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5797d = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x80e0aabd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80e0aabd:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x80e0ab3f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,5);
		code_r0x80e0ab3f:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  func_ii_8753(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060045B9 RID: 17849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B9")]
		[Address(RVA = "0x945B", Offset = "0x945B", VA = "0x945B")]
		private void CloseWindow()
		{
		/* --- GHIDRA: CloseWindow ---
		void Gameplay_Cave_Controller_CaveWindowMediator__CloseWindow(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5797e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_BossCombatModel__BossCombatEvents__BossCombatController__BossCombatViewMediator__OneOnOneCombatView__Dispose__
		              );
		    DAT_ram_00a5797e = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___CheckRunRestrictions
		            (param1,
		             Method_Gameplay_Combat_AbstractCombat_BossCombatModel__BossCombatEvents__BossCombatController__BossCombatViewMediator__OneOnOneCombatView__Dispose__
		            );
		  *(undefined4 *)(param1 + 0x28) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0400261E RID: 9758
		[Token(Token = "0x400261E")]
		public const string CAVE_FIND_TIP = "CAVE/FINDING_TIP";

		// Token: 0x0400261F RID: 9759
		[Token(Token = "0x400261F")]
		public const string CAVE_FOUND_RESOURCE = "CAVE/FOUND_RESOURCE";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Cave_Controller_CaveWindowMediator__set_Events(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57974 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CaveModel__CaveEvents__CaveController__CaveWindow__get_Model__
		              );
		    DAT_ram_00a57974 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar1 + 0x60) + 0x18),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)*(byte *)(param1[2] + 0x10),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar1 + 0x60) + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)*(byte *)(param1[2] + 0x10),0);
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Cave_Controller_CaveWindowMediator__set_View
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57977 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_CaveWindowArgs__get_BackButton__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_WindowWhitCloseButton_CaveWindowArgs__get_CloseButton__);
		    DAT_ram_00a57977 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar1 + 0x34),param2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar1 + 0x38),param2,0);
		  return;
		}
		*/

}
