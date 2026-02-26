using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using Utils.Cache;

namespace Gameplay.Chat.View.Messages
{
	// Token: 0x02000AFA RID: 2810
	[Token(Token = "0x2000AFA")]
	public class ChatMiniMessagesCarousel : MonoBehaviour
	{
		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x060043C3 RID: 17347 RVA: 0x0000CC78 File Offset: 0x0000AE78
		[Token(Token = "0x17000D5D")]
		public int MAXCount
		{
			[Token(Token = "0x60043C3")]
			[Address(RVA = "0x9276", Offset = "0x9276", VA = "0x9276")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060043C4 RID: 17348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043C4")]
		[Address(RVA = "0x9277", Offset = "0x9277", VA = "0x9277")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		int Gameplay_Chat_View_Messages_ChatMiniMessagesCarousel__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int param1_01;
		  undefined4 param3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57b05 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Chat_View_Messages_ChatMiniMessagesCarousel_ResetPoolObjectDelegate__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Cache_GameObjectPool_ChatMiniMessageRenderer___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_Cache_GameObjectPool_ChatMiniMessageRenderer__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Utils_Cache_ObjectPool_ResetPoolObjectDelegate_ChatMiniMessageRenderer__TypeInfo);
		    DAT_ram_00a57b05 = '\x01';
		  }
		  param1_01 = *(int *)(param1 + 0x30);
		  if (param1_01 == 0) {
		    param3 = *(undefined4 *)(param1 + 0x10);
		    param2_00 = *(undefined4 *)(param1 + 0x14);
		    param1_00 = unnamed_function_1417
		                          (
		                          Utils_Cache_ObjectPool_ResetPoolObjectDelegate_ChatMiniMessageRenderer__TypeInfo
		                          );
		    Core_Cache_AbstractCache_RequestInvoker___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____ctor
		              (param1_00,param1,
		               Method_Gameplay_Chat_View_Messages_ChatMiniMessagesCarousel_ResetPoolObjectDelegate__
		               ,0);
		    param1_01 = unnamed_function_1417(Utils_Cache_GameObjectPool_ChatMiniMessageRenderer__TypeInfo);
		    Utils_Cache_GameObjectPoolRestricted_object___CreateInstance
		              (param1_01,param2_00,param3,param1_00,
		               Method_Utils_Cache_GameObjectPool_ChatMiniMessageRenderer___ctor__);
		    *(int *)(param1 + 0x30) = param1_01;
		  }
		  return param1_01;
		}
		*/

		}

		// Token: 0x060043C5 RID: 17349 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60043C5")]
		[Address(RVA = "0x9278", Offset = "0x9278", VA = "0x9278")]
		private GameObjectPool<ChatMiniMessageRenderer> GetPool()
		{
		/* --- GHIDRA: GetPool ---
		void Gameplay_Chat_View_Messages_ChatMiniMessagesCarousel__GetPool(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57b06 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_LinkedListNode_ChatMiniMessageRenderer__get_Value__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_ChatMiniMessageRenderer__RemoveFirst__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_ChatMiniMessageRenderer__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_ChatMiniMessageRenderer__get_First__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_ChatMiniMessageRenderer__Release__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_string__Clear__);
		    DAT_ram_00a57b06 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x34);
		  iVar2 = *(int *)(iVar1 + 0xc);
		  while (0 < iVar2) {
		    iVar1 = *(int *)(iVar1 + 8);
		    func_ii_8007(*(undefined4 *)(iVar1 + 0x14),0,0);
		    func_ii_7070(*(undefined4 *)(param1 + 0x30),*(undefined4 *)(iVar1 + 0x14),
		                 Method_Utils_Cache_ObjectPool_ChatMiniMessageRenderer__Release__);
		    System_Collections_Generic_LinkedList_object___OnDeserialization
		              (*(undefined4 *)(param1 + 0x34),
		               Method_System_Collections_Generic_LinkedList_ChatMiniMessageRenderer__RemoveFirst__);
		    iVar1 = *(int *)(param1 + 0x34);
		    iVar2 = *(int *)(iVar1 + 0xc);
		  }
		  System_Collections_Generic_Queue_MeshGenerationDeferrer_CallbackInfo____ctor
		            (*(undefined4 *)(param1 + 0x38),Method_System_Collections_Generic_Queue_string__Clear__)
		  ;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060043C6 RID: 17350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043C6")]
		[Address(RVA = "0x9279", Offset = "0x9279", VA = "0x9279")]
		public void Clear()
		{
		/* --- GHIDRA: Clear ---
		float Gameplay_Chat_View_Messages_ChatMiniMessagesCarousel__Clear(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  float fVar2;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  iVar1 = UnityEngine_InputSystem_Users_InputUser__UnpairDevices(param1_00,0);
		  if (iVar1 == 0) {
		    fVar2 = 0.0;
		  }
		  else {
		    fVar2 = *(float *)(param1 + 0x2c);
		  }
		  return fVar2;
		}
		*/

		}

		// Token: 0x060043C7 RID: 17351 RVA: 0x0000CC90 File Offset: 0x0000AE90
		[Token(Token = "0x60043C7")]
		[Address(RVA = "0x927A", Offset = "0x927A", VA = "0x927A")]
		public float GetMoveDuration()
		{
		/* --- GHIDRA: GetMoveDuration ---
		void Gameplay_Chat_View_Messages_ChatMiniMessagesCarousel__GetMoveDuration
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  undefined4 param2_00;
		  undefined4 param3_00;
		  float param4;
		  
		  if (DAT_ram_00a57b07 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_string__Enqueue__);
		    DAT_ram_00a57b07 = '\x01';
		  }
		  iVar2 = *(int *)(param2 + 0xc);
		  if (0 < iVar2) {
		    iVar1 = 0;
		    do {
		      System_Collections_Generic_Dictionary_Int32Enum__object___TryGetValue
		                (*(undefined4 *)(param1 + 0x38),*(undefined4 *)(param2 + iVar1 * 4 + 0x10),
		                 Method_System_Collections_Generic_Queue_string__Enqueue__);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 != iVar2);
		  }
		  param2_00 = *(undefined4 *)(param1 + 0x38);
		  param3_00 = *(undefined4 *)(param1 + 0x34);
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  iVar2 = UnityEngine_InputSystem_Users_InputUser__UnpairDevices(param1_00,0);
		  if (iVar2 == 0) {
		    param4 = 0.0;
		  }
		  else {
		    param4 = *(float *)(param1 + 0x2c);
		  }
		  Gameplay_Chat_View_Messages_ChatMiniMessagesCarousel__AddMessage
		            (param1,param2_00,param3_00,param4,param3_00);
		  return;
		}
		*/

			return 0f;
		}

		// Token: 0x060043C8 RID: 17352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043C8")]
		[Address(RVA = "0x927B", Offset = "0x927B", VA = "0x927B")]
		public void AddMessage(params string[] texts)
		{
		/* --- GHIDRA: AddMessage ---
		void Gameplay_Chat_View_Messages_ChatMiniMessagesCarousel__AddMessage
		               (int param1,undefined4 param2,undefined4 param3,float param4,undefined4 param5)
		
		{
		  bool bVar1;
		  int param2_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint uVar4;
		  int iVar5;
		  float fVar6;
		  float4 fVar7;
		  int *piVar8;
		  int iVar9;
		  longlong local_80;
		  undefined4 local_78;
		  undefined8 local_70;
		  undefined4 local_68;
		  longlong local_60;
		  undefined4 local_58;
		  undefined8 local_50;
		  undefined4 local_48;
		  undefined4 local_40;
		  float4 local_3c;
		  undefined4 local_38;
		  float4 local_34;
		  float4 local_30;
		  undefined4 local_2c;
		  undefined4 local_28;
		  float4 local_24;
		  undefined4 local_20;
		  undefined8 local_1c;
		  undefined4 local_14;
		  undefined1 auStack_10 [12];
		  float4 local_4;
		  
		  if (DAT_ram_00a57b08 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_DOTween_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedListNode_ChatMiniMessageRenderer__get_Next__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_LinkedListNode_ChatMiniMessageRenderer__get_Value__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_ChatMiniMessageRenderer__AddLast__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_ChatMiniMessageRenderer__RemoveFirst__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_ChatMiniMessageRenderer__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_ChatMiniMessageRenderer__get_First__);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_ChatMiniMessageRenderer__Get__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_string__Dequeue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_string__get_Count__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_OnComplete_Sequence___)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Chat_View_Messages_ChatMiniMessagesCarousel___c__DisplayClass16_0__HandleQueues_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Chat_View_Messages_ChatMiniMessagesCarousel___c__DisplayClass16_0__HandleQueues_b__1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Chat_View_Messages_ChatMiniMessagesCarousel___c__DisplayClass16_0__HandleQueues_b__2__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Chat_View_Messages_ChatMiniMessagesCarousel___c__DisplayClass16_0_TypeInfo)
		    ;
		    DAT_ram_00a57b08 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Chat_View_Messages_ChatMiniMessagesCarousel___c__DisplayClass16_0_TypeInfo
		                        );
		  *(float *)(param2_00 + 0x18) = param4;
		  *(undefined4 *)(param2_00 + 0x14) = param3;
		  *(undefined4 *)(param2_00 + 0x10) = param2;
		  *(int *)(param2_00 + 8) = param1;
		  uVar2 = func_ii_5677(*(undefined4 *)(param1 + 0x14),
		                       Method_UnityEngine_Component_GetComponent_RectTransform___);
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties(auStack_10,uVar2,0);
		  iVar9 = *(int *)(param1 + 0x18);
		  uVar4 = *(int *)(*(int *)(param2_00 + 0x14) + 0xc) - iVar9;
		  if ((int)uVar4 < 1) {
		    iVar5 = *(int *)(*(int *)(param2_00 + 0x10) + 0x14);
		    if (0 < iVar5) {
		      if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_Math_TypeInfo);
		      }
		      uVar4 = UnityEngine_Mathf__Min(iVar9,iVar5,0);
		      if (*(int *)(DG_Tweening_DOTween_TypeInfo + 0x74) == 0) {
		        func_ii_306000(DG_Tweening_DOTween_TypeInfo);
		      }
		      uVar2 = DG_Tweening_DOTween__To(0);
		      if (0 < (int)uVar4) {
		        do {
		          uVar3 = Gameplay_Chat_View_Messages_ChatMiniMessagesCarousel__OnDestroy(param1,&local_80);
		          uVar3 = Gameplay_Combat_View_VFX_StoneDestroyVFX__GetPool
		                            (uVar3,Method_Utils_Cache_ObjectPool_ChatMiniMessageRenderer__Get__);
		          *(undefined4 *)(param2_00 + 0xc) = uVar3;
		          uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (uVar3,0);
		          Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                    (uVar3,1,0);
		          fVar6 = *(float *)(param1 + 0x20);
		          iVar9 = *(int *)(*(int *)(param2_00 + 0x14) + 0xc);
		          fVar7 = *(float4 *)(param1 + 0x1c);
		          uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (*(undefined4 *)(param2_00 + 0xc),0);
		          uVar3 = UnityEngine_UI_Selectable__set_interactable(uVar3,0);
		          local_2c = 0;
		          local_68 = 0;
		          local_30 = (float4)(fVar6 - (float)local_4 * (float)iVar9);
		          local_70 = CONCAT44(local_30,fVar7);
		          local_34 = fVar7;
		          Gameplay_Isles_User_View_IsleAccountMarkersLayerView__GetView(uVar3,&local_70,0);
		          iVar9 = *(int *)(param2_00 + 0xc);
		          uVar3 = func_ii_7387(*(undefined4 *)(param2_00 + 0x10),
		                               Method_System_Collections_Generic_Queue_string__Dequeue__);
		          piVar8 = *(int **)(iVar9 + 0x10);
		          iVar9 = *piVar8;
		          (**(code **)((ulonglong)*(uint *)(iVar9 + 0x2d0) * 4))
		                    (piVar8,uVar3,*(undefined4 *)(iVar9 + 0x2d4));
		          uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                            (*(undefined4 *)(param2_00 + 0xc),0);
		          local_38 = 0;
		          local_78 = 0;
		          local_40 = 0;
		          local_3c = (float4)((float)local_4 * (float)-*(int *)(*(int *)(param2_00 + 0x14) + 0xc));
		          local_80 = (ulonglong)(uint)local_3c << 0x20;
		          uVar3 = DG_Tweening_ShortcutExtensions__DOMoveZ
		                            (uVar3,&local_80,*(float *)(param2_00 + 0x18),0,0);
		          DG_Tweening_TweenSettingsExtensions__Join(uVar2,0.0,uVar3,0);
		          System_Collections_Generic_LinkedList_object____ctor
		                    (*(undefined4 *)(param2_00 + 0x14),*(undefined4 *)(param2_00 + 0xc),
		                     Method_System_Collections_Generic_LinkedList_ChatMiniMessageRenderer__AddLast__
		                    );
		          bVar1 = 1 < uVar4;
		          uVar4 = uVar4 - 1;
		        } while (bVar1);
		      }
		      uVar3 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		      DG_Tweening_Color2__op_Multiply
		                (uVar3,param2_00,
		                 Method_Gameplay_Chat_View_Messages_ChatMiniMessagesCarousel___c__DisplayClass16_0__HandleQueues_b__2__
		                 ,0);
		      DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		                (uVar2,uVar3,Method_DG_Tweening_TweenSettingsExtensions_OnComplete_Sequence___);
		    }
		  }
		  else {
		    do {
		      *(undefined4 *)(param2_00 + 0xc) =
		           *(undefined4 *)(*(int *)(*(int *)(param2_00 + 0x14) + 8) + 0x14);
		      System_Collections_Generic_LinkedList_object___OnDeserialization
		                (*(int *)(param2_00 + 0x14),
		                 Method_System_Collections_Generic_LinkedList_ChatMiniMessageRenderer__RemoveFirst__
		                );
		      uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (*(undefined4 *)(param2_00 + 0xc),0);
		      local_50 = *(undefined8 *)(param1 + 0x24);
		      local_14 = 0;
		      local_48 = 0;
		      local_1c = local_50;
		      uVar2 = DG_Tweening_ShortcutExtensions__DOMoveZ
		                        (uVar2,&local_50,*(float *)(param2_00 + 0x18),0,0);
		      iVar9 = *(int *)(param2_00 + 0x1c);
		      if (iVar9 == 0) {
		        iVar9 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		        DG_Tweening_Color2__op_Multiply
		                  (iVar9,param2_00,
		                   Method_Gameplay_Chat_View_Messages_ChatMiniMessagesCarousel___c__DisplayClass16_0__HandleQueues_b__0__
		                   ,0);
		        *(int *)(param2_00 + 0x1c) = iVar9;
		      }
		      DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		                (uVar2,iVar9,
		                 Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Vector3__VectorOptions____
		                );
		      bVar1 = 1 < uVar4;
		      uVar4 = uVar4 - 1;
		    } while (bVar1);
		    iVar9 = *(int *)(*(int *)(param2_00 + 0x14) + 8);
		    if (*(int *)(DG_Tweening_DOTween_TypeInfo + 0x74) == 0) {
		      func_ii_306000(DG_Tweening_DOTween_TypeInfo);
		    }
		    uVar2 = DG_Tweening_DOTween__To(0);
		    if (iVar9 != 0) {
		      iVar5 = 0;
		      do {
		        uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                          (*(undefined4 *)(iVar9 + 0x14),0);
		        local_20 = 0;
		        local_58 = 0;
		        local_24 = (float4)(-(float)local_4 * (float)iVar5);
		        local_28 = 0;
		        local_60 = (ulonglong)(uint)local_24 << 0x20;
		        uVar3 = DG_Tweening_ShortcutExtensions__DOMoveZ
		                          (uVar3,&local_60,*(float *)(param2_00 + 0x18),0,0);
		        DG_Tweening_TweenSettingsExtensions__Join(uVar2,0.0,uVar3,0);
		        iVar5 = iVar5 + 1;
		        iVar9 = System_Net_Sockets_Socket__Bind
		                          (iVar9,
		                           Method_System_Collections_Generic_LinkedListNode_ChatMiniMessageRenderer__get_Next__
		                          );
		      } while (iVar9 != 0);
		    }
		    uVar3 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		    DG_Tweening_Color2__op_Multiply
		              (uVar3,param2_00,
		               Method_Gameplay_Chat_View_Messages_ChatMiniMessagesCarousel___c__DisplayClass16_0__HandleQueues_b__1__
		               ,0);
		    DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		              (uVar2,uVar3,Method_DG_Tweening_TweenSettingsExtensions_OnComplete_Sequence___);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060043C9 RID: 17353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043C9")]
		[Address(RVA = "0x927C", Offset = "0x927C", VA = "0x927C")]
		private void HandleQueues(Queue<string> awaitMessages, LinkedList<ChatMiniMessageRenderer> displayed, float duration)
		{
		/* --- GHIDRA: HandleQueues ---
		void Gameplay_Chat_View_Messages_ChatMiniMessagesCarousel__HandleQueues
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x060043CA RID: 17354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043CA")]
		[Address(RVA = "0x927D", Offset = "0x927D", VA = "0x927D")]
		private void ResetPoolObjectDelegate(ChatMiniMessageRenderer pooledobject)
		{
		/* --- GHIDRA: ResetPoolObjectDelegate ---
		void Gameplay_Chat_View_Messages_ChatMiniMessagesCarousel__ResetPoolObjectDelegate
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57b09 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_ChatMiniMessageRenderer___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_LinkedList_ChatMiniMessageRenderer__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Queue_string__TypeInfo);
		    DAT_ram_00a57b09 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x2c) = 0x3ecccccd;
		  *(undefined4 *)(param1 + 0x18) = 3;
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_LinkedList_ChatMiniMessageRenderer__TypeInfo);
		  *(undefined4 *)(param1 + 0x34) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_Queue_string__TypeInfo);
		  Sirenix_Serialization_StackFormatter_object____Il2CppFullySharedGenericType___SerializeImplementation
		            (uVar1,Method_System_Collections_Generic_Queue_string___ctor__);
		  *(undefined4 *)(param1 + 0x38) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060043CB RID: 17355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043CB")]
		[Address(RVA = "0x927E", Offset = "0x927E", VA = "0x927E")]
		public ChatMiniMessagesCarousel()
		{
		}

		// Token: 0x04002555 RID: 9557
		[Token(Token = "0x4002555")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _messagesContainer;

		// Token: 0x04002556 RID: 9558
		[Token(Token = "0x4002556")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ChatMiniMessageRenderer _messagePrefab;

		// Token: 0x04002557 RID: 9559
		[Token(Token = "0x4002557")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _maxCount;

		// Token: 0x04002558 RID: 9560
		[Token(Token = "0x4002558")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Vector2 _spawnPoint;

		// Token: 0x04002559 RID: 9561
		[Token(Token = "0x4002559")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Vector2 _destroyPoint;

		// Token: 0x0400255A RID: 9562
		[Token(Token = "0x400255A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _moveDuration;

		// Token: 0x0400255B RID: 9563
		[Token(Token = "0x400255B")]
		[FieldOffset(Offset = "0x30")]
		private GameObjectPool<ChatMiniMessageRenderer> _messagesPool;

		// Token: 0x0400255C RID: 9564
		[Token(Token = "0x400255C")]
		[FieldOffset(Offset = "0x34")]
		private LinkedList<ChatMiniMessageRenderer> _displayedMessages;

		// Token: 0x0400255D RID: 9565
		[Token(Token = "0x400255D")]
		[FieldOffset(Offset = "0x38")]
		private Queue<string> _awaitMessages;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_MAXCount ---
		void Gameplay_Chat_View_Messages_ChatMiniMessagesCarousel__get_MAXCount
		               (int param1,undefined4 param2)
		
		{
		  Gameplay_Chat_View_Messages_ChatMiniMessagesCarousel__GetPool(param1,param1);
		  *(undefined4 *)(param1 + 0x38) = 0;
		  *(undefined8 *)(param1 + 0x30) = 0;
		  return;
		}
		*/

}
