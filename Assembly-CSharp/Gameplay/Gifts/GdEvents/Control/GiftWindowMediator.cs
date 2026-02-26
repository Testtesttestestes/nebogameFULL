using System;
using Gameplay.Gifts.Events;
using Gameplay.Gifts.GdEvents.Model;
using Gameplay.Gifts.GdEvents.View;
using Gameplay.Gifts.View;
using Il2CppDummyDll;
using MVC;
using TMPro;

namespace Gameplay.Gifts.GdEvents.Control
{
	// Token: 0x02000716 RID: 1814
	[Token(Token = "0x2000716")]
	public class GiftWindowMediator : AbstractViewMediator<GiftModel, GiftsEvents, GiftController, GiftWindow>
	{
		// Token: 0x06002B65 RID: 11109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B65")]
		[Address(RVA = "0x7BFD", Offset = "0x7BFD", VA = "0x7BFD")]
		public GiftWindowMediator(GiftModel model, GiftsEvents events, GiftController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Gifts_GdEvents_Control_GiftWindowMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5a241 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GiftModel__GiftsEvents__GiftController__GiftWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Gifts_GdEvents_Control_GiftWindowMediator_GiftSentEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Gifts_GdEvents_Control_GiftWindowMediator_GiftsStatusRequestedEventHandler__
		              );
		    DAT_ram_00a5a241 = '\x01';
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
		               Method_Gameplay_Gifts_GdEvents_Control_GiftWindowMediator_GiftSentEventHandler__,0);
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Gifts_GdEvents_Control_GiftWindowMediator_GiftsStatusRequestedEventHandler__
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
		               Method_Gameplay_Gifts_GdEvents_Control_GiftWindowMediator_GiftSentEventHandler__,0);
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Gifts_GdEvents_Control_GiftWindowMediator_GiftsStatusRequestedEventHandler__
		               ,0);
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

		// Token: 0x17000848 RID: 2120
		// (set) Token: 0x06002B66 RID: 11110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000848")]
		public override GiftsEvents Events
		{
			[Token(Token = "0x6002B66")]
			[Address(RVA = "0x7BFE", Offset = "0x7BFE", VA = "0x7BFE", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000849 RID: 2121
		// (set) Token: 0x06002B67 RID: 11111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000849")]
		public override GiftWindow View
		{
			[Token(Token = "0x6002B67")]
			[Address(RVA = "0x7BFF", Offset = "0x7BFF", VA = "0x7BFF", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002B68 RID: 11112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B68")]
		[Address(RVA = "0x7C00", Offset = "0x7C00", VA = "0x7C00")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Gifts_GdEvents_Control_GiftWindowMediator__ResetView(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param3;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a243 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GiftModel__GiftsEvents__GiftController__GiftWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_GiftWindow_GiftWindowArgs__get_WindowArgs__);
		    DAT_ram_00a5a243 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param3 = *(undefined4 *)(param1[2] + 8);
		  param1_01 = *(undefined4 *)(iVar1 + 0x3c);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = func_ii_8093(param1_00,
		                       Method_UI_Windows_BaseWindow_GiftWindow_GiftWindowArgs__get_WindowArgs__);
		  Gameplay_Gifts_View_GiftView__OnDestroy(param1_01,*(undefined4 *)(iVar1 + 0x18),param3,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B69")]
		[Address(RVA = "0x7C01", Offset = "0x7C01", VA = "0x7C01")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Gifts_GdEvents_Control_GiftWindowMediator__SetupView
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined4 local_28;
		  undefined8 local_24;
		  undefined8 local_1c;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a244 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_GiftWindowMediator__SendGiftEventHandler_d__7___
		              );
		    DAT_ram_00a5a244 = '\x01';
		  }
		  local_4 = 0;
		  local_c = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_38,0);
		  local_1c = local_30;
		  local_28 = 0xffffffff;
		  local_24 = local_38;
		  local_14 = param1;
		  local_10 = param2;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_GameEventsController__SetEvents_d__8_
		            (&local_24,&local_28,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_GiftWindowMediator__SendGiftEventHandler_d__7___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B6A")]
		[Address(RVA = "0x7C02", Offset = "0x7C02", VA = "0x7C02")]
		private void SendGiftEventHandler(GiftView view)
		{
		/* --- GHIDRA: SendGiftEventHandler ---
		void Gameplay_Gifts_GdEvents_Control_GiftWindowMediator__SendGiftEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Gifts_GdEvents_Control_GiftWindowMediator__GiftsStatusRequestedEventHandler
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B6B")]
		[Address(RVA = "0x7C03", Offset = "0x7C03", VA = "0x7C03")]
		private void GiftSentEventHandler()
		{
		/* --- GHIDRA: GiftSentEventHandler ---
		void Gameplay_Gifts_GdEvents_Control_GiftWindowMediator__GiftSentEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a245 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GiftModel__GiftsEvents__GiftController__GiftWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_GiftView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_GiftWindow_GiftWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Gifts_GdEvents_Control_GiftWindowMediator_SendGiftEventHandler__);
		    DAT_ram_00a5a245 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param3 = *(undefined4 *)(param1[2] + 8);
		  param1_00 = *(undefined4 *)(iVar1 + 0x3c);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = func_ii_8093(uVar2,
		                       Method_UI_Windows_BaseWindow_GiftWindow_GiftWindowArgs__get_WindowArgs__);
		  Gameplay_Gifts_View_GiftView__OnDestroy(param1_00,*(undefined4 *)(iVar1 + 0x18),param3,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = *(int *)(iVar1 + 0x3c);
		  uVar2 = unnamed_function_1417(System_Action_GiftView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Gifts_GdEvents_Control_GiftWindowMediator_SendGiftEventHandler__,0);
		  *(undefined4 *)(iVar1 + 0x24) = uVar2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x1c),1,0);
		  Gameplay_Gifts_GdEvents_Control_GiftWindowMediator__GiftsStatusRequestedEventHandler
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002B6C RID: 11116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B6C")]
		[Address(RVA = "0x7C04", Offset = "0x7C04", VA = "0x7C04")]
		private void GiftsStatusRequestedEventHandler()
		{
		/* --- GHIDRA: GiftsStatusRequestedEventHandler ---
		void Gameplay_Gifts_GdEvents_Control_GiftWindowMediator__GiftsStatusRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 param3;
		  undefined4 param4;
		  uint *param1_00;
		  undefined4 param2_00;
		  int iVar3;
		  int *param1_01;
		  
		  param3 = 0;
		  if (DAT_ram_00a5a246 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GiftModel__GiftsEvents__GiftController__GiftWindow__get_Model__
		              );
		    DAT_ram_00a5a246 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param2_00 = *(undefined4 *)(iVar2 + 0x40);
		  iVar2 = param1[2];
		  if (*(int *)(iVar2 + 0xc) != 0) {
		    param3 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator
		                       (*(int *)(iVar2 + 0xc),0);
		    iVar2 = param1[2];
		  }
		  param4 = Gameplay_Gifts_Model_GiftsModel__get_GiftsSent(iVar2,param1);
		  iVar3 = param1[2];
		  iVar2 = Gameplay_Gifts_Model_GiftsModel__get_GiftsSent(iVar3,iVar3);
		  if (DAT_ram_00a5a224 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_ulong__TypeInfo);
		    DAT_ram_00a5a224 = '\x01';
		  }
		  param1_01 = *(int **)(iVar3 + 0x14);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_ulong__TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        param1_00 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811ec847;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  param1_00 = (uint *)func_ii_1080(param1_01,System_Collections_Generic_ICollection_ulong__TypeInfo,
		                                   0);
		code_r0x811ec847:
		  iVar3 = (**(code **)((ulonglong)*param1_00 * 4))(param1_01,param1_00[1]);
		  Gameplay_Gifts_GdEvents_Control_GiftWindowMediator__RefreshAnnotation
		            (param1_00,param2_00,param3,param4,iVar2 - iVar3,param1_00);
		  return;
		}
		*/

		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B6D")]
		[Address(RVA = "0x7C05", Offset = "0x7C05", VA = "0x7C05")]
		private void RefreshAnnotation()
		{
		/* --- GHIDRA: RefreshAnnotation ---
		void Gameplay_Gifts_GdEvents_Control_GiftWindowMediator__RefreshAnnotation
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 param3_00;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  local_4 = param4;
		  if (DAT_ram_00a5a247 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_47);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8380);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25316);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8373);
		    Mono_Security_ASN1__get_Item(&StringLiteral_527);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28594);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8371);
		    DAT_ram_00a5a247 = '\x01';
		  }
		  iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(param3,0);
		  if (iVar1 == 0) {
		    param3 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                       (StringLiteral_527,param3,StringLiteral_527,0);
		  }
		  iVar1 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,7);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_8380,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  uVar2 = StringLiteral_118;
		  *(undefined4 *)(iVar1 + 0x18) = param3;
		  *(undefined4 *)(iVar1 + 0x14) = uVar2;
		  *(undefined4 *)(iVar1 + 0x1c) = StringLiteral_47;
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_8373,1,0,1,0,0,0,0);
		  uVar3 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar3,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  param3_00 = func_ii_4443(&local_4,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar3,StringLiteral_25316,param3_00,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar2 = Core_GameLocalization__GetTranslation(uVar2,uVar3,0);
		  *(undefined4 *)(iVar1 + 0x20) = uVar2;
		  *(undefined4 *)(iVar1 + 0x24) = StringLiteral_47;
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_8371,1,0,1,0,0,0,0);
		  local_8 = param5;
		  uVar3 = func_ii_1081(DAT_ram_00a66954,&local_8);
		  uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28594,uVar2,uVar3,0);
		  *(undefined4 *)(iVar1 + 0x28) = uVar2;
		  uVar2 = System_Single__ToString(iVar1,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param2,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B6E")]
		[Address(RVA = "0x7C06", Offset = "0x7C06", VA = "0x7C06")]
		private void UpdateAnnotation(TextMeshProUGUI text, string owner, int maxGifts, int giftsLeft)
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Gifts_GdEvents_Control_GiftWindowMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param3_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a242 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GiftModel__GiftsEvents__GiftController__GiftWindow__set_View__
		              );
		    DAT_ram_00a5a242 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    *(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0x24) = 0;
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    if (DAT_ram_00a5a243 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_GiftModel__GiftsEvents__GiftController__GiftWindow__get_Model__
		                );
		      Mono_Security_ASN1__get_Item
		                (&Method_UI_Windows_BaseWindow_GiftWindow_GiftWindowArgs__get_WindowArgs__);
		      DAT_ram_00a5a243 = '\x01';
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param3_00 = *(undefined4 *)(param1[2] + 8);
		    param1_00 = *(undefined4 *)(iVar2 + 0x3c);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar2 = func_ii_8093(uVar1,
		                         Method_UI_Windows_BaseWindow_GiftWindow_GiftWindowArgs__get_WindowArgs__);
		    Gameplay_Gifts_View_GiftView__OnDestroy
		              (param1_00,*(undefined4 *)(iVar2 + 0x18),param3_00,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Gifts_GdEvents_Control_GiftWindowMediator__set_View(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  *(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x24) = 0;
		  return;
		}
		*/

}
