using System;
using System.Runtime.CompilerServices;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using UI.Price;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Boss.View.CaptainTab
{
	// Token: 0x02000B77 RID: 2935
	[Token(Token = "0x2000B77")]
	public class BossAttackOptionView : MonoBehaviour
	{
		// Token: 0x140001C1 RID: 449
		// (add) Token: 0x06004745 RID: 18245 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004746 RID: 18246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001C1")]
		public event Action<BossInfo.BossAttackOption, BossInfo.BossAttackOption.BossAttackOptionVariant> AttackButtonClickEvent
		{
			[Token(Token = "0x6004745")]
			[Address(RVA = "0x95DB", Offset = "0x95DB", VA = "0x95DB")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004746")]
			[Address(RVA = "0x95DC", Offset = "0x95DC", VA = "0x95DC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06004747 RID: 18247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004747")]
		[Address(RVA = "0x95DD", Offset = "0x95DD", VA = "0x95DD")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Boss_View_CaptainTab_BossAttackOptionView__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a57a36 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Item__
		              );
		    DAT_ram_00a57a36 = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x2c);
		  if (iVar2 != 0) {
		    iVar3 = *(int *)(param1 + 0x34);
		    uVar1 = System_Linq_Enumerable__ToList_object_
		                      (*(undefined4 *)(iVar3 + 0xc),*(undefined4 *)(param1 + 0x30),
		                       Method_System_Collections_Generic_List_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Item__
		                      );
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),iVar3,uVar1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004748 RID: 18248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004748")]
		[Address(RVA = "0x95DE", Offset = "0x95DE", VA = "0x95DE")]
		private void AttackButtonClickHandler()
		{
		/* --- GHIDRA: AttackButtonClickHandler ---
		void Gameplay_Boss_View_CaptainTab_BossAttackOptionView__AttackButtonClickHandler
		               (int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int param1_01;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57a37 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionView_AttackButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionView_DecrementButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionView_IncrementButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionView_PickerWindowOnClose__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionView_PickerWindowOnSelectedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57a37 = '\x01';
		  }
		  uVar5 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar3,param1,
		             Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionView_IncrementButtonClickHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar5,uVar3,0);
		  uVar5 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar3,param1,
		             Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionView_DecrementButtonClickHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar5,uVar3,0);
		  uVar5 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar3,param1,
		             Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionView_AttackButtonClickHandler__,0)
		  ;
		  UnityEngine_Events_UnityAction___ctor(uVar5,uVar3,0);
		  uVar3 = *(undefined4 *)(param1 + 0x28);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar4 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar3,0,0);
		  if (iVar4 != 0) {
		    iVar4 = *(int *)(param1 + 0x28);
		    uVar3 = unnamed_function_1417
		                      (System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionView_PickerWindowOnSelectedEvent__
		               ,0);
		    if (DAT_ram_00a57a29 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo);
		      DAT_ram_00a57a29 = '\x01';
		    }
		    param1_00 = *(int *)(iVar4 + 0x5c);
		    do {
		      iVar2 = 0;
		      param1_01 = func_ii_7048(param1_00,uVar3,0);
		      uVar5 = System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo;
		      if ((param1_01 != 0) &&
		         (iVar2 = func_ii_1082(param1_01,
		                               System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo
		                              ), iVar2 == 0)) {
		        System_Activator__CreateInstance(param1_01,uVar5);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar2 = func_ii_4329(iVar4 + 0x5c,iVar2,param1_00);
		      bVar1 = iVar2 != param1_00;
		      param1_00 = iVar2;
		    } while (bVar1);
		    uVar5 = *(undefined4 *)(param1 + 0x28);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionView_PickerWindowOnClose__,0);
		    UI_Windows_BaseWindow__add_onClose(uVar5,uVar3,0);
		    *(undefined4 *)(param1 + 0x28) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004749 RID: 18249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004749")]
		[Address(RVA = "0x95DF", Offset = "0x95DF", VA = "0x95DF")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Boss_View_CaptainTab_BossAttackOptionView__OnDestroy(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57a38 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Count__
		              );
		    DAT_ram_00a57a38 = '\x01';
		  }
		  if (*(int *)(param1 + 0x34) != 0) {
		    iVar1 = *(int *)(param1 + 0x24) + 1;
		    *(int *)(param1 + 0x24) = iVar1;
		    if (2 < iVar1) {
		      Gameplay_Boss_View_CaptainTab_BossAttackOptionView__RenderVariant(param1,param1);
		      return;
		    }
		    iVar1 = *(int *)(param1 + 0x30) + -1;
		    *(int *)(param1 + 0x30) = iVar1;
		    if (iVar1 < 0) {
		      *(int *)(param1 + 0x30) = *(int *)(*(int *)(*(int *)(param1 + 0x34) + 0xc) + 0xc) + -1;
		    }
		    Gameplay_Boss_View_CaptainTab_BossAttackOptionView__get_Data(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600474A RID: 18250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600474A")]
		[Address(RVA = "0x95E0", Offset = "0x95E0", VA = "0x95E0")]
		private void DecrementButtonClickHandler()
		{
		/* --- GHIDRA: DecrementButtonClickHandler ---
		void Gameplay_Boss_View_CaptainTab_BossAttackOptionView__DecrementButtonClickHandler
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57a39 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Count__
		              );
		    DAT_ram_00a57a39 = '\x01';
		  }
		  if (*(int *)(param1 + 0x34) != 0) {
		    iVar1 = *(int *)(param1 + 0x24) + 1;
		    *(int *)(param1 + 0x24) = iVar1;
		    if (2 < iVar1) {
		      Gameplay_Boss_View_CaptainTab_BossAttackOptionView__RenderVariant(param1,param1);
		      return;
		    }
		    iVar1 = *(int *)(param1 + 0x30) + 1;
		    if (*(int *)(*(int *)(*(int *)(param1 + 0x34) + 0xc) + 0xc) + -1 < iVar1) {
		      iVar1 = 0;
		    }
		    *(int *)(param1 + 0x30) = iVar1;
		    Gameplay_Boss_View_CaptainTab_BossAttackOptionView__get_Data(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600474B RID: 18251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600474B")]
		[Address(RVA = "0x95E1", Offset = "0x95E1", VA = "0x95E1")]
		private void IncrementButtonClickHandler()
		{
		}

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x0600474C RID: 18252 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600474D RID: 18253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E37")]
		public BossInfo.BossAttackOption Data
		{
			[Token(Token = "0x600474C")]
			[Address(RVA = "0x95E2", Offset = "0x95E2", VA = "0x95E2")]
			get
			{
				return null;
			}
			[Token(Token = "0x600474D")]
			[Address(RVA = "0x1BA4", Offset = "0x1BA4", VA = "0x1BA4")]
			set
			{
			}
		}

		// Token: 0x0600474E RID: 18254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600474E")]
		[Address(RVA = "0x95E3", Offset = "0x95E3", VA = "0x95E3")]
		private void RenderVariant()
		{
		/* --- GHIDRA: RenderVariant ---
		void Gameplay_Boss_View_CaptainTab_BossAttackOptionView__RenderVariant(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_01;
		  undefined4 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a57a3c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionView_PickerWindowOnClose__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionView_PickerWindowOnSelectedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Item__
		              );
		    DAT_ram_00a57a3c = '\x01';
		  }
		  iVar5 = *(int *)(param1 + 0x34);
		  uVar3 = System_Linq_Enumerable__ToList_object_
		                    (*(undefined4 *)(iVar5 + 0xc),*(undefined4 *)(param1 + 0x30),
		                     Method_System_Collections_Generic_List_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Item__
		                    );
		  iVar5 = Gameplay_Boss_View_CaptainTab_BossAttackOptionPickerDialogWindow__HandleContent
		                    (iVar5,uVar3,iVar5);
		  *(int *)(param1 + 0x28) = iVar5;
		  uVar3 = unnamed_function_1417
		                    (System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionView_PickerWindowOnSelectedEvent__
		             ,0);
		  if (DAT_ram_00a57a28 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo);
		    DAT_ram_00a57a28 = '\x01';
		  }
		  param1_00 = *(int *)(iVar5 + 0x5c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,uVar3,0);
		    uVar4 = System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,
		                             System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo
		                            ), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar5 + 0x5c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      uVar4 = *(undefined4 *)(param1 + 0x28);
		      uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		      UnityEngine_Events_UnityEvent__AddListener
		                (uVar3,param1,
		                 Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionView_PickerWindowOnClose__,0);
		      UI_Windows_BaseWindow__get_IsActiveResourceBar(uVar4,uVar3,0);
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600474F RID: 18255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600474F")]
		[Address(RVA = "0x95E4", Offset = "0x95E4", VA = "0x95E4")]
		private void ShowValuePicker()
		{
		}

		// Token: 0x06004750 RID: 18256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004750")]
		[Address(RVA = "0x95E5", Offset = "0x95E5", VA = "0x95E5")]
		private void PickerWindowOnSelectedEvent(BossInfo.BossAttackOption.BossAttackOptionVariant variant)
		{
		/* --- GHIDRA: PickerWindowOnSelectedEvent ---
		void Gameplay_Boss_View_CaptainTab_BossAttackOptionView__PickerWindowOnSelectedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57a3d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BossInfo_BossAttackOption_BossAttackOptionVariant__IndexOf__
		              );
		    DAT_ram_00a57a3d = '\x01';
		  }
		  uVar1 = UnityEngine_UIElements_RadioButtonGroup__GetAllRadioButtons
		                    (*(undefined4 *)(*(int *)(param1 + 0x34) + 0xc),param2,
		                     Method_System_Collections_Generic_List_BossInfo_BossAttackOption_BossAttackOptionVariant__IndexOf__
		                    );
		  *(undefined4 *)(param1 + 0x30) = uVar1;
		  Gameplay_Boss_View_CaptainTab_BossAttackOptionView__get_Data(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004751 RID: 18257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004751")]
		[Address(RVA = "0x95E6", Offset = "0x95E6", VA = "0x95E6")]
		public void SelectVariant(BossInfo.BossAttackOption.BossAttackOptionVariant variant)
		{
		/* --- GHIDRA: SelectVariant ---
		void Gameplay_Boss_View_CaptainTab_BossAttackOptionView__SelectVariant(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_01;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57a3f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionView_PickerWindowOnClose__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionView_PickerWindowOnSelectedEvent__
		              );
		    DAT_ram_00a57a3f = '\x01';
		  }
		  iVar4 = *(int *)(param1 + 0x28);
		  uVar3 = unnamed_function_1417
		                    (System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionView_PickerWindowOnSelectedEvent__
		             ,0);
		  if (DAT_ram_00a57a29 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo);
		    DAT_ram_00a57a29 = '\x01';
		  }
		  param1_00 = *(int *)(iVar4 + 0x5c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,uVar3,0);
		    uVar5 = System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,
		                             System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo
		                            ), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar4 + 0x5c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      uVar5 = *(undefined4 *)(param1 + 0x28);
		      uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		      UnityEngine_Events_UnityEvent__AddListener
		                (uVar3,param1,
		                 Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionView_PickerWindowOnClose__,0);
		      UI_Windows_BaseWindow__add_onClose(uVar5,uVar3,0);
		      *(undefined4 *)(param1 + 0x28) = 0;
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		/* --- GHIDRA: SelectVariant ---
		void Gameplay_Boss_View_CaptainTab_BossAttackOptionView__SelectVariant(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_01;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57a3f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionView_PickerWindowOnClose__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionView_PickerWindowOnSelectedEvent__
		              );
		    DAT_ram_00a57a3f = '\x01';
		  }
		  iVar4 = *(int *)(param1 + 0x28);
		  uVar3 = unnamed_function_1417
		                    (System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionView_PickerWindowOnSelectedEvent__
		             ,0);
		  if (DAT_ram_00a57a29 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo);
		    DAT_ram_00a57a29 = '\x01';
		  }
		  param1_00 = *(int *)(iVar4 + 0x5c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,uVar3,0);
		    uVar5 = System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,
		                             System_Action_BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo
		                            ), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar4 + 0x5c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      uVar5 = *(undefined4 *)(param1 + 0x28);
		      uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		      UnityEngine_Events_UnityEvent__AddListener
		                (uVar3,param1,
		                 Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionView_PickerWindowOnClose__,0);
		      UI_Windows_BaseWindow__add_onClose(uVar5,uVar3,0);
		      *(undefined4 *)(param1 + 0x28) = 0;
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004752 RID: 18258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004752")]
		[Address(RVA = "0x1B40", Offset = "0x1B40", VA = "0x1B40")]
		public void SelectVariant(int variantId)
		{
		}

		// Token: 0x06004753 RID: 18259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004753")]
		[Address(RVA = "0x95E7", Offset = "0x95E7", VA = "0x95E7")]
		private void PickerWindowOnClose()
		{
		}

		// Token: 0x06004754 RID: 18260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004754")]
		[Address(RVA = "0x95E8", Offset = "0x95E8", VA = "0x95E8")]
		public BossAttackOptionView()
		{
		}

		// Token: 0x04002717 RID: 10007
		[Token(Token = "0x4002717")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _attackButton;

		// Token: 0x04002718 RID: 10008
		[Token(Token = "0x4002718")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Price _price;

		// Token: 0x04002719 RID: 10009
		[Token(Token = "0x4002719")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _incrementButton;

		// Token: 0x0400271A RID: 10010
		[Token(Token = "0x400271A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _decrementButton;

		// Token: 0x0400271B RID: 10011
		[Token(Token = "0x400271B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BossAttackSkillBonusView _bossAttackSkillBonusView;

		// Token: 0x0400271C RID: 10012
		[Token(Token = "0x400271C")]
		[FieldOffset(Offset = "0x24")]
		private int _changeButtonClickNum;

		// Token: 0x0400271D RID: 10013
		[Token(Token = "0x400271D")]
		private const int CLICKS_TO_OPEN_VALUE_PICKER = 3;

		// Token: 0x0400271E RID: 10014
		[Token(Token = "0x400271E")]
		[FieldOffset(Offset = "0x28")]
		private BossAttackOptionPickerDialogWindow _pickerWindow;

		// Token: 0x04002720 RID: 10016
		[Token(Token = "0x4002720")]
		[FieldOffset(Offset = "0x30")]
		private int _currentVariantIndex;

		// Token: 0x04002721 RID: 10017
		[Token(Token = "0x4002721")]
		[FieldOffset(Offset = "0x34")]
		private BossInfo.BossAttackOption _data;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_AttackButtonClickEvent ---
		void Gameplay_Boss_View_CaptainTab_BossAttackOptionView__add_AttackButtonClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57a34 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Action_BossInfo_BossAttackOption__BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo
		              );
		    DAT_ram_00a57a34 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = 
		    System_Action_BossInfo_BossAttackOption__BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo
		    ;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,
		                             System_Action_BossInfo_BossAttackOption__BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo
		                            ), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x2c,iVar2,param1_00);
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


		/* --- GHIDRA: remove_AttackButtonClickEvent ---
		void Gameplay_Boss_View_CaptainTab_BossAttackOptionView__remove_AttackButtonClickEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57a35 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionView_AttackButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionView_DecrementButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionView_IncrementButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57a35 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionView_IncrementButtonClickHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionView_DecrementButtonClickHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Boss_View_CaptainTab_BossAttackOptionView_AttackButtonClickHandler__,0)
		  ;
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  return;
		}
		*/


		/* --- GHIDRA: get_Data ---
		void Gameplay_Boss_View_CaptainTab_BossAttackOptionView__get_Data(int param1,undefined4 param2)
		
		{
		  char cVar1;
		  uint uVar2;
		  int param1_00;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int *param1_01;
		  int iVar7;
		  
		  if (DAT_ram_00a57a3b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Item__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a57a3b = '\x01';
		  }
		  if (*(int *)(param1 + 0x34) != 0) {
		    param1_00 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(*(int *)(param1 + 0x34) + 0xc),
		                           *(undefined4 *)(param1 + 0x30),
		                           Method_System_Collections_Generic_List_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Item__
		                          );
		    cVar1 = *(char *)(param1_00 + 0x10);
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x20),0);
		    if (cVar1 == '\0') {
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar3,0,0);
		    }
		    else {
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar3,1,0);
		      Gameplay_Boss_View_CaptainTab_BossAttackSkillBonusView__get_Skills
		                (*(undefined4 *)(param1 + 0x20),*(undefined4 *)(param1_00 + 0xc),param1);
		    }
		    uVar3 = *(undefined4 *)(param1 + 0x14);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar7 = *param1_01;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + iVar7 + 0x140);
		          goto code_r0x80e1675a;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e1675a:
		    uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(param1_01,puVar4[1]);
		    uVar5 = func_ii_7112(uVar5,0);
		    uVar6 = com_unity3d_mediation_LevelPlayBannerAd___ctor(param1_00,0);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    uVar6 = Core_Money_Money__op_Explicit(uVar6,0);
		    UI_Price_Price__SetColor(uVar3,uVar5,uVar6,0);
		  }
		  return;
		}
		*/

}
