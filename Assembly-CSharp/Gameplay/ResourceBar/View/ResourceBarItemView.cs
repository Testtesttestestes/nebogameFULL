using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Gameplay.Accounts.Model.Data;
using Gameplay.User.Model;
using Il2CppDummyDll;
using Protocol.Consts;
using Protocol.Dic;
using UI.ToolTip;
using UI.ToolTip.Implementations;
using UnityEngine;
using UnityEngine.EventSystems;
using Utils.Cache;

namespace Gameplay.ResourceBar.View
{
	// Token: 0x0200054F RID: 1359
	[Token(Token = "0x200054F")]
	public class ResourceBarItemView : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler, IToolTipDataProvider
	{
		// Token: 0x1400013D RID: 317
		// (add) Token: 0x0600209D RID: 8349 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600209E RID: 8350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400013D")]
		public event Action<Protocol.Consts.Resources> ClickEvent
		{
			[Token(Token = "0x600209D")]
			[Address(RVA = "0x7202", Offset = "0x7202", VA = "0x7202")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600209E")]
			[Address(RVA = "0x7203", Offset = "0x7203", VA = "0x7203")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x0600209F RID: 8351 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005F7")]
		public ResourceBarIconValueView IconValueView
		{
			[Token(Token = "0x600209F")]
			[Address(RVA = "0x7204", Offset = "0x7204", VA = "0x7204")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x060020A0 RID: 8352 RVA: 0x00006978 File Offset: 0x00004B78
		// (set) Token: 0x060020A1 RID: 8353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005F8")]
		public bool IsInteractive
		{
			[Token(Token = "0x60020A0")]
			[Address(RVA = "0x7205", Offset = "0x7205", VA = "0x7205")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020A1")]
			[Address(RVA = "0x7206", Offset = "0x7206", VA = "0x7206")]
			set
			{
			}
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A2")]
		[Address(RVA = "0x7207", Offset = "0x7207", VA = "0x7207")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_ResourceBar_View_ResourceBarItemView__Awake
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  Utils_TweenContainer__AddTween(*(undefined4 *)(param2 + 0x3c),0);
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A3")]
		[Address(RVA = "0x7208", Offset = "0x7208", VA = "0x7208")]
		private void ResetPoolObjectDelegate(ResourceBarDeltaView pooledObject)
		{
		/* --- GHIDRA: ResetPoolObjectDelegate ---
		void Gameplay_ResourceBar_View_ResourceBarItemView__ResetPoolObjectDelegate
		               (int param1,undefined4 param2,undefined4 param3,int param4,undefined4 param5)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  
		  *(undefined4 *)(param1 + 0x50) = param3;
		  *(undefined4 *)(param1 + 0x4c) = param2;
		  if ((*(int *)(param1 + 0x54) != param4) && (*(int *)(param1 + 0x54) = param4, param4 != 0)) {
		    iVar1 = *(int *)(param1 + 0x10);
		    param2_00 = Core_Extensions_Dict_DictExt__GetResourcesDic(param4,0);
		    *(undefined4 *)(iVar1 + 0x28) = param2_00;
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66
		              (*(undefined4 *)(iVar1 + 0x10),param2_00,0);
		    *(int *)(*(int *)(param1 + 0x1c) + 0x2c) = param1;
		    *(int *)(*(int *)(param1 + 0x20) + 0x2c) = param1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A4")]
		[Address(RVA = "0x7209", Offset = "0x7209", VA = "0x7209")]
		public void Init(UserModel userModel, TradeAccount tradeAccount, ResourcesDic resourcesDict)
		{
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x060020A5 RID: 8357 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060020A6 RID: 8358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005F9")]
		public UserModel UserModel
		{
			[Token(Token = "0x60020A5")]
			[Address(RVA = "0x720A", Offset = "0x720A", VA = "0x720A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60020A6")]
			[Address(RVA = "0x720B", Offset = "0x720B", VA = "0x720B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x060020A7 RID: 8359 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060020A8 RID: 8360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005FA")]
		public TradeAccount TradeAccount
		{
			[Token(Token = "0x60020A7")]
			[Address(RVA = "0x720C", Offset = "0x720C", VA = "0x720C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60020A8")]
			[Address(RVA = "0x720D", Offset = "0x720D", VA = "0x720D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x060020A9 RID: 8361 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060020AA RID: 8362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005FB")]
		public ResourcesDic ResourcesDic
		{
			[Token(Token = "0x60020A9")]
			[Address(RVA = "0x720E", Offset = "0x720E", VA = "0x720E")]
			get
			{
				return null;
			}
			[Token(Token = "0x60020AA")]
			[Address(RVA = "0x720F", Offset = "0x720F", VA = "0x720F")]
			private set
			{
			}
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020AB")]
		[Address(RVA = "0x7210", Offset = "0x7210", VA = "0x7210")]
		private void HandleResourcesDicChanged()
		{
		/* --- GHIDRA: HandleResourcesDicChanged ---
		void Gameplay_ResourceBar_View_ResourceBarItemView__HandleResourcesDicChanged
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (*(undefined4 *)(*(int *)(param1 + 0x10) + 0x10),0);
		  func_ii_8007(param1_00,0,0);
		  if (*(int *)(param1 + 0x54) != 0) {
		    *(undefined4 *)(param1 + 0x54) = 0;
		  }
		  *(undefined8 *)(param1 + 0x4c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060020AC RID: 8364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020AC")]
		[Address(RVA = "0x7211", Offset = "0x7211", VA = "0x7211")]
		private void OnDestroy()
		{
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x060020AD RID: 8365 RVA: 0x00006990 File Offset: 0x00004B90
		// (set) Token: 0x060020AE RID: 8366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005FC")]
		public double Value
		{
			[Token(Token = "0x60020AD")]
			[Address(RVA = "0x7212", Offset = "0x7212", VA = "0x7212")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60020AE")]
			[Address(RVA = "0x7213", Offset = "0x7213", VA = "0x7213")]
			set
			{
			}
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020AF")]
		[Address(RVA = "0x7214", Offset = "0x7214", VA = "0x7214", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void Gameplay_ResourceBar_View_ResourceBarItemView__OnPointerClick
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5832a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    DAT_ram_00a5832a = '\x01';
		  }
		  if (*(char *)(param1 + 0x44) != '\0') {
		    uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (*(undefined4 *)(*(int *)(param1 + 0x10) + 0x10),0);
		    func_ii_8007(uVar1,0,0);
		    uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (*(undefined4 *)(*(int *)(param1 + 0x10) + 0x10),0);
		    local_4 = 0;
		    local_10 = 0;
		    local_c = 0x3f9333333f933333;
		    local_18 = 0x3f9333333f933333;
		    uVar1 = System_Collections_Generic_Queue_object___Dequeue(uVar1,&local_18,0.1,0);
		    DG_Tweening_ShortcutExtensions__DOScale
		              (uVar1,5,
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B0")]
		[Address(RVA = "0x7215", Offset = "0x7215", VA = "0x7215", Slot = "5")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerEnter ---
		void Gameplay_ResourceBar_View_ResourceBarItemView__OnPointerEnter
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5832b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    DAT_ram_00a5832b = '\x01';
		  }
		  if (*(char *)(param1 + 0x44) != '\0') {
		    uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (*(undefined4 *)(*(int *)(param1 + 0x10) + 0x10),0);
		    func_ii_8007(uVar1,0,0);
		    uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (*(undefined4 *)(*(int *)(param1 + 0x10) + 0x10),0);
		    local_4 = 0;
		    local_10 = 0;
		    local_c = 0x3f8000003f800000;
		    local_18 = 0x3f8000003f800000;
		    uVar1 = System_Collections_Generic_Queue_object___Dequeue(uVar1,&local_18,0.4,0);
		    uVar1 = DG_Tweening_ShortcutExtensions__DOScale
		                      (uVar1,6,
		                       Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                      );
		    DG_Tweening_DOTweenModuleUI__DOFade
		              (uVar1,0.1,
		               Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B1")]
		[Address(RVA = "0x7216", Offset = "0x7216", VA = "0x7216", Slot = "6")]
		public void OnPointerExit(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerExit ---
		void Gameplay_ResourceBar_View_ResourceBarItemView__OnPointerExit
		               (int param1,double param2,double param3,undefined4 param4)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5832c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Queue_ResourceBarItemView_ResourceDeltaData__Enqueue__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ResourceBar_View_ResourceBarItemView_ResourceDeltaData_TypeInfo);
		    DAT_ram_00a5832c = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x3c);
		  param2_00 = unnamed_function_1417
		                        (Gameplay_ResourceBar_View_ResourceBarItemView_ResourceDeltaData_TypeInfo);
		  *(double *)(param2_00 + 8) = param3;
		  *(double *)(param2_00 + 0x10) = param2;
		  System_Collections_Generic_Dictionary_Int32Enum__object___TryGetValue
		            (param1_00,param2_00,
		             Method_System_Collections_Generic_Queue_ResourceBarItemView_ResourceDeltaData__Enqueue__
		            );
		  System_Collections_Generic_Queue_object___Enqueue(param1,param2_00);
		  return;
		}
		*/

		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B2")]
		[Address(RVA = "0x7217", Offset = "0x7217", VA = "0x7217")]
		public void ShowDeltaAnimation(double delta, double targetAmount)
		{
		/* --- GHIDRA: ShowDeltaAnimation ---
		void Gameplay_ResourceBar_View_ResourceBarItemView__ShowDeltaAnimation
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  float4 local_8;
		  
		  if (DAT_ram_00a5832f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_LayoutElement___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_RectTransform___);
		    DAT_ram_00a5832f = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  piVar2 = (int *)func_ii_6601(uVar1,Method_UnityEngine_GameObject_GetComponent_LayoutElement___);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  uVar1 = func_ii_6601(uVar1,Method_UnityEngine_GameObject_GetComponent_RectTransform___);
		  UnityEngine_RectTransform__set_anchoredPosition(&local_8,uVar1,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x1e0) * 4))
		            (piVar2,local_8,*(undefined4 *)(*piVar2 + 0x1e4));
		  return;
		}
		*/

		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B3")]
		[Address(RVA = "0x1CCF", Offset = "0x1CCF", VA = "0x1CCF")]
		public void DisposeAllDeltaAnimation()
		{
		/* --- GHIDRA: DisposeAllDeltaAnimation ---
		int * Gameplay_ResourceBar_View_ResourceBarItemView__DisposeAllDeltaAnimation(int *param1)
		
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

		// Token: 0x060020B4 RID: 8372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B4")]
		[Address(RVA = "0x1CD4", Offset = "0x1CD4", VA = "0x1CD4")]
		private void HandleQueue()
		{
		/* --- GHIDRA: HandleQueue ---
		int * Gameplay_ResourceBar_View_ResourceBarItemView__HandleQueue(int *param1)
		
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

		// Token: 0x060020B5 RID: 8373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B5")]
		[Address(RVA = "0x7218", Offset = "0x7218", VA = "0x7218")]
		private void OnFirstDeltaAnimationStart()
		{
		/* --- GHIDRA: OnFirstDeltaAnimationStart ---
		void Gameplay_ResourceBar_View_ResourceBarItemView__OnFirstDeltaAnimationStart
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *piVar1;
		  
		  if (DAT_ram_00a58330 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_LayoutElement___);
		    DAT_ram_00a58330 = '\x01';
		  }
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  piVar1 = (int *)func_ii_6601(param1_00,Method_UnityEngine_GameObject_GetComponent_LayoutElement___
		                              );
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x1e0) * 4))
		            (piVar1,0xbf800000,*(undefined4 *)(*piVar1 + 0x1e4));
		  return;
		}
		*/

		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B6")]
		[Address(RVA = "0x7219", Offset = "0x7219", VA = "0x7219")]
		private void OnLastDeltaAnimationComplete()
		{
		/* --- GHIDRA: OnLastDeltaAnimationComplete ---
		void Gameplay_ResourceBar_View_ResourceBarItemView__OnLastDeltaAnimationComplete
		               (int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x48) = 0;
		  System_Collections_Generic_Queue_object___Enqueue(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B7")]
		[Address(RVA = "0x721A", Offset = "0x721A", VA = "0x721A")]
		private void OnBlockComplete()
		{
		/* --- GHIDRA: OnBlockComplete ---
		void Gameplay_ResourceBar_View_ResourceBarItemView__OnBlockComplete
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int *piVar1;
		  
		  if (DAT_ram_00a58331 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_ResourceBarDeltaView__Remove__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_ResourceBarDeltaView__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_ResourceBarDeltaView__Release__);
		    DAT_ram_00a58331 = '\x01';
		  }
		  Unity_Services_Analytics_AnalyticsService__get_Instance
		            (*(undefined4 *)(param1 + 0x38),param2,
		             Method_System_Collections_Generic_HashSet_ResourceBarDeltaView__Remove__);
		  func_ii_7070(*(undefined4 *)(param1 + 0x34),param2,
		               Method_Utils_Cache_ObjectPool_ResourceBarDeltaView__Release__);
		  if (*(int *)(*(int *)(param1 + 0x38) + 0x10) == 0) {
		    if (DAT_ram_00a58330 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_LayoutElement___);
		      DAT_ram_00a58330 = '\x01';
		    }
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (param1,0);
		    piVar1 = (int *)func_ii_6601(param1_00,
		                                 Method_UnityEngine_GameObject_GetComponent_LayoutElement___);
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x1e0) * 4))
		              (piVar1,0xbf800000,*(undefined4 *)(*piVar1 + 0x1e4));
		  }
		  System_Collections_Generic_Queue_object___Enqueue(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B8")]
		[Address(RVA = "0x721B", Offset = "0x721B", VA = "0x721B")]
		private void CompleteCallback(ResourceBarDeltaView deltaView)
		{
		/* --- GHIDRA: CompleteCallback ---
		void Gameplay_ResourceBar_View_ResourceBarItemView__CompleteCallback
		               (int param1,double param2,float param3,undefined4 param4)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  double dVar2;
		  
		  if (DAT_ram_00a58332 == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_float__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetEase_Tweener___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ResourceBar_View_ResourceBarItemView___c__DisplayClass53_0__ChangeValueSmooth_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ResourceBar_View_ResourceBarItemView___c__DisplayClass53_0_TypeInfo);
		    DAT_ram_00a58332 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_ResourceBar_View_ResourceBarItemView___c__DisplayClass53_0_TypeInfo
		                        );
		  *(int *)(param2_00 + 8) = param1;
		  if (*(int *)(param1 + 0x40) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x40),0,0);
		  }
		  dVar2 = *(double *)(param1 + 0x58);
		  *(double *)(param2_00 + 0x10) = param2;
		  *(double *)(param2_00 + 0x18) = param2 - dVar2;
		  uVar1 = unnamed_function_1417(DG_Tweening_TweenCallback_float__TypeInfo);
		  DG_Tweening_TweenCallback_int___Invoke
		            (uVar1,param2_00,
		             Method_Gameplay_ResourceBar_View_ResourceBarItemView___c__DisplayClass53_0__ChangeValueSmooth_b__0__
		             ,0);
		  uVar1 = DG_Tweening_DOTween___c__DisplayClass67_0___To_b__1(1.0,0.0,param3,uVar1,0);
		  uVar1 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar1,6,Method_DG_Tweening_TweenSettingsExtensions_SetEase_Tweener___);
		  *(undefined4 *)(param1 + 0x40) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B9")]
		[Address(RVA = "0x721C", Offset = "0x721C", VA = "0x721C")]
		private void ChangeValueSmooth(double newValue, float duration)
		{
		/* --- GHIDRA: ChangeValueSmooth ---
		int Gameplay_ResourceBar_View_ResourceBarItemView__ChangeValueSmooth(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int param2_00;
		  undefined4 uVar3;
		  double dVar4;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58333 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_string___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_string__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22118);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27779);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2169);
		    DAT_ram_00a58333 = '\x01';
		  }
		  iVar1 = Gameplay_Accounts_Model_Data_TradeAccount__Init
		                    (*(undefined4 *)(param1 + 0x50),*(undefined4 *)(param1 + 0x24),
		                     *(undefined4 *)(*(int *)(param1 + 0x4c) + 8),0);
		  if (iVar1 == 0) {
		    uVar2 = Core_Extensions_Dict_ResourcesDicExt__GetLimitToolTipText
		                      (*(undefined4 *)(param1 + 0x54),0);
		  }
		  else {
		    uVar2 = Core_Extensions_Dict_ResourcesDicExt__GetDescription(*(undefined4 *)(param1 + 0x54),0);
		  }
		  param2_00 = Mono_Security_ASN1Convert__ToOid
		                        (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,2);
		  dVar4 = *(double *)(param1 + 0x58);
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  uVar3 = UI_SimpleIconValue__set_IconAssetId(dVar4,StringLiteral_28780,0);
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_22118,uVar3,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(param2_00 + 0x10) = local_8;
		  dVar4 = func_ii_6906(iVar1,*(undefined4 *)(param1 + 0x24),0);
		  uVar3 = UI_SimpleIconValue__set_IconAssetId(dVar4,StringLiteral_28780,0);
		  local_10 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,StringLiteral_27779,uVar3,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(param2_00 + 0x18) = local_10;
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar2,param2_00,0);
		  uVar3 = Core_Extensions_Dict_ResourcesDicExt__GetTitle(*(undefined4 *)(param1 + 0x54),0);
		  uVar2 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (uVar3,StringLiteral_2169,uVar2,0);
		  iVar1 = unnamed_function_1417(UI_ToolTip_ToolTipData_string__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (iVar1,0,Method_UI_ToolTip_ToolTipData_string___ctor__);
		  *(undefined4 *)(iVar1 + 0x1c) = uVar2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x060020BA RID: 8378 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60020BA")]
		[Address(RVA = "0x721D", Offset = "0x721D", VA = "0x721D", Slot = "8")]
		public virtual BaseToolTipData GetData()
		{
		/* --- GHIDRA: GetData ---
		void Gameplay_ResourceBar_View_ResourceBarItemView__GetData(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58334 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_ResourceBarDeltaView___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_HashSet_ResourceBarDeltaView__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Queue_ResourceBarItemView_ResourceDeltaData___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Queue_ResourceBarItemView_ResourceDeltaData__TypeInfo);
		    DAT_ram_00a58334 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_HashSet_ResourceBarDeltaView__TypeInfo);
		  func_ii_7115(uVar1,Method_System_Collections_Generic_HashSet_ResourceBarDeltaView___ctor__);
		  *(undefined4 *)(param1 + 0x38) = uVar1;
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Queue_ResourceBarItemView_ResourceDeltaData__TypeInfo
		                    );
		  Sirenix_Serialization_StackFormatter_object____Il2CppFullySharedGenericType___SerializeImplementation
		            (uVar1,
		             Method_System_Collections_Generic_Queue_ResourceBarItemView_ResourceDeltaData___ctor__)
		  ;
		  *(undefined4 *)(param1 + 0x3c) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060020BB RID: 8379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020BB")]
		[Address(RVA = "0x721E", Offset = "0x721E", VA = "0x721E")]
		public ResourceBarItemView()
		{
		}

		// Token: 0x040011CC RID: 4556
		[Token(Token = "0x40011CC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ResourceBarIconValueView _iconValueView;

		// Token: 0x040011CD RID: 4557
		[Token(Token = "0x40011CD")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _animationContainer;

		// Token: 0x040011CE RID: 4558
		[Token(Token = "0x40011CE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ResourceBarDeltaView _deltaPrefab;

		// Token: 0x040011CF RID: 4559
		[Token(Token = "0x40011CF")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextToolTip _iconToolTip;

		// Token: 0x040011D0 RID: 4560
		[Token(Token = "0x40011D0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextToolTip _valueToolTip;

		// Token: 0x040011D1 RID: 4561
		[Token(Token = "0x40011D1")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		public Protocol.Consts.Resources Resource;

		// Token: 0x040011D2 RID: 4562
		[Token(Token = "0x40011D2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _defaultDuration;

		// Token: 0x040011D3 RID: 4563
		[Token(Token = "0x40011D3")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Минимальное время до следующей генерации delta view на случай очереди из нескольких показов на запрос изменения баланса")]
		[SerializeField]
		private float _minTimeBetweenGenerateDeltaView;

		// Token: 0x040011D5 RID: 4565
		[Token(Token = "0x40011D5")]
		[FieldOffset(Offset = "0x34")]
		private GameObjectPool<ResourceBarDeltaView> _deltaViewPool;

		// Token: 0x040011D6 RID: 4566
		[Token(Token = "0x40011D6")]
		[FieldOffset(Offset = "0x38")]
		private HashSet<ResourceBarDeltaView> _currentViews;

		// Token: 0x040011D7 RID: 4567
		[Token(Token = "0x40011D7")]
		[FieldOffset(Offset = "0x3C")]
		private Queue<ResourceBarItemView.ResourceDeltaData> _deltaQueue;

		// Token: 0x040011D8 RID: 4568
		[Token(Token = "0x40011D8")]
		[FieldOffset(Offset = "0x40")]
		private Tweener _changeValueSmoothTweener;

		// Token: 0x040011D9 RID: 4569
		[Token(Token = "0x40011D9")]
		[FieldOffset(Offset = "0x44")]
		private bool _isInteractive;

		// Token: 0x040011DA RID: 4570
		[Token(Token = "0x40011DA")]
		[FieldOffset(Offset = "0x48")]
		private Tween _blockTween;

		// Token: 0x040011DD RID: 4573
		[Token(Token = "0x40011DD")]
		[FieldOffset(Offset = "0x54")]
		private ResourcesDic _resourcesDic;

		// Token: 0x040011DE RID: 4574
		[Token(Token = "0x40011DE")]
		[FieldOffset(Offset = "0x58")]
		private double _value;

		// Token: 0x02000550 RID: 1360
		[Token(Token = "0x2000550")]
		public class ResourceDeltaData
		{
			// Token: 0x060020BC RID: 8380 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60020BC")]
			[Address(RVA = "0x721F", Offset = "0x721F", VA = "0x721F")]
			public ResourceDeltaData()
			{
			}

			// Token: 0x040011DF RID: 4575
			[Token(Token = "0x40011DF")]
			[FieldOffset(Offset = "0x8")]
			public double TargetAmount;

			// Token: 0x040011E0 RID: 4576
			[Token(Token = "0x40011E0")]
			[FieldOffset(Offset = "0x10")]
			public double DeltaAmount;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ClickEvent ---
		void Gameplay_ResourceBar_View_ResourceBarItemView__add_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58327 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_Resources__TypeInfo);
		    DAT_ram_00a58327 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_Resources__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_Resources__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x30,iVar2,param1_00);
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


		/* --- GHIDRA: get_IsInteractive ---
		void Gameplay_ResourceBar_View_ResourceBarItemView__get_IsInteractive
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  *(char *)(param1 + 0x44) = (char)param2;
		  if (param2 == 0) {
		    uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (*(undefined4 *)(*(int *)(param1 + 0x10) + 0x10),0);
		    func_ii_8007(uVar1,0,0);
		    uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (*(undefined4 *)(*(int *)(param1 + 0x10) + 0x10),0);
		    if (DAT_ram_00a6501f == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		      DAT_ram_00a6501f = '\x01';
		    }
		    local_8 = *(undefined4 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0x14);
		    local_10 = *(undefined8 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0xc);
		    Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(uVar1,&local_10,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_IsInteractive ---
		void Gameplay_ResourceBar_View_ResourceBarItemView__set_IsInteractive(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  undefined4 param3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58328 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_GameObjectPool_ResourceBarDeltaView___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_Cache_GameObjectPool_ResourceBarDeltaView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Utils_Cache_ObjectPool_ResetPoolObjectDelegate_ResourceBarDeltaView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ResourceBar_View_ResourceBarItemView_ResetPoolObjectDelegate__);
		    DAT_ram_00a58328 = '\x01';
		  }
		  param3 = *(undefined4 *)(param1 + 0x14);
		  param2_00 = *(undefined4 *)(param1 + 0x18);
		  param1_00 = unnamed_function_1417
		                        (
		                        Utils_Cache_ObjectPool_ResetPoolObjectDelegate_ResourceBarDeltaView__TypeInfo
		                        );
		  Core_Cache_AbstractCache_RequestInvoker___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____ctor
		            (param1_00,param1,
		             Method_Gameplay_ResourceBar_View_ResourceBarItemView_ResetPoolObjectDelegate__,0);
		  param1_01 = unnamed_function_1417(Utils_Cache_GameObjectPool_ResourceBarDeltaView__TypeInfo);
		  Utils_Cache_GameObjectPoolRestricted_object___CreateInstance
		            (param1_01,param2_00,param3,param1_00,
		             Method_Utils_Cache_GameObjectPool_ResourceBarDeltaView___ctor__);
		  *(undefined4 *)(param1 + 0x34) = param1_01;
		  return;
		}
		*/


		/* --- GHIDRA: get_ResourcesDic ---
		void Gameplay_ResourceBar_View_ResourceBarItemView__get_ResourcesDic
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  
		  if ((*(int *)(param1 + 0x54) != param2) && (*(int *)(param1 + 0x54) = param2, param2 != 0)) {
		    iVar1 = *(int *)(param1 + 0x10);
		    param2_00 = Core_Extensions_Dict_DictExt__GetResourcesDic(param2,0);
		    *(undefined4 *)(iVar1 + 0x28) = param2_00;
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66
		              (*(undefined4 *)(iVar1 + 0x10),param2_00,0);
		    *(int *)(*(int *)(param1 + 0x1c) + 0x2c) = param1;
		    *(int *)(*(int *)(param1 + 0x20) + 0x2c) = param1;
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_ResourcesDic ---
		void Gameplay_ResourceBar_View_ResourceBarItemView__set_ResourcesDic(int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  
		  if (*(int *)(param1 + 0x54) != 0) {
		    iVar1 = *(int *)(param1 + 0x10);
		    param2_00 = Core_Extensions_Dict_DictExt__GetResourcesDic(*(int *)(param1 + 0x54),0);
		    *(undefined4 *)(iVar1 + 0x28) = param2_00;
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66
		              (*(undefined4 *)(iVar1 + 0x10),param2_00,0);
		    *(int *)(*(int *)(param1 + 0x1c) + 0x2c) = param1;
		    *(int *)(*(int *)(param1 + 0x20) + 0x2c) = param1;
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_Value ---
		void Gameplay_ResourceBar_View_ResourceBarItemView__get_Value
		               (int param1,double param2,undefined4 param3)
		
		{
		  undefined8 uVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int iVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a58329 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    DAT_ram_00a58329 = '\x01';
		  }
		  *(double *)(param1 + 0x58) = param2;
		  iVar3 = *(int *)(param1 + 0x10);
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  param2_00 = func_ii_7372(param2,0);
		  piVar4 = *(int **)(iVar3 + 0x14);
		  iVar5 = *piVar4;
		  uVar1 = CONCAT44((int)((ulonglong)param2 >> 0x20),piVar4);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x2c8) * 4))
		                        (uVar1,*(undefined4 *)(iVar5 + 0x2cc));
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  iVar5 = System_Collections_CollectionBase___ctor(param1_00,param2_00,0);
		  if (iVar5 == 0) {
		    piVar4 = *(int **)(iVar3 + 0x14);
		    iVar3 = *piVar4;
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		              (CONCAT44(uVar2,piVar4),param2_00,*(undefined4 *)(iVar3 + 0x2d4));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Value ---
		void Gameplay_ResourceBar_View_ResourceBarItemView__set_Value
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if ((*(char *)(param1 + 0x44) != '\0') && (iVar1 = *(int *)(param1 + 0x30), iVar1 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x24),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

}
