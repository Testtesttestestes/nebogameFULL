using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScreenAdaptation.Common;
using UnityEngine;

namespace ScreenAdaptation.Scale
{
	// Token: 0x020000B3 RID: 179
	[Token(Token = "0x20000B3")]
	public class GameScaler : MonoBehaviour
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060006EE RID: 1774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B6")]
		public static GameScaler Instance
		{
			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x5AEA", Offset = "0x5AEA", VA = "0x5AEA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x5AEB", Offset = "0x5AEB", VA = "0x5AEB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x5AEC", Offset = "0x5AEC", VA = "0x5AEC")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void ScreenAdaptation_Scale_GameScaler__Awake(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a5b809 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5b809 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x10,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x140000BF RID: 191
		// (add) Token: 0x060006F0 RID: 1776 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006F1 RID: 1777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000BF")]
		public event Action GameContentScaledEvent
		{
			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x5AED", Offset = "0x5AED", VA = "0x5AED")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x5AEE", Offset = "0x5AEE", VA = "0x5AEE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x5AEF", Offset = "0x5AEF", VA = "0x5AEF")]
		public void AddCamera(Camera cam)
		{
		/* --- GHIDRA: AddCamera ---
		void ScreenAdaptation_Scale_GameScaler__AddCamera(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5b80c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_Camera__Remove__);
		    DAT_ram_00a5b80c = '\x01';
		  }
		  uVar1 = Unity_Services_Analytics_AnalyticsService__get_Instance
		                    (*(undefined4 *)(param1 + 0x18),param2,
		                     Method_System_Collections_Generic_HashSet_Camera__Remove__);
		  *(char *)(param1 + 0x20) = (char)uVar1;
		  return;
		}
		*/

		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x5AF0", Offset = "0x5AF0", VA = "0x5AF0")]
		public void RemoveCamera(Camera cam)
		{
		/* --- GHIDRA: RemoveCamera ---
		void ScreenAdaptation_Scale_GameScaler__RemoveCamera(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5b80d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_Canvas__Add__);
		    DAT_ram_00a5b80d = '\x01';
		  }
		  uVar1 = System_Collections_Generic_HashSet_object___Clear
		                    (*(undefined4 *)(param1 + 0x1c),param2,
		                     Method_System_Collections_Generic_HashSet_Canvas__Add__);
		  *(char *)(param1 + 0x20) = (char)uVar1;
		  return;
		}
		*/

		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x5AF1", Offset = "0x5AF1", VA = "0x5AF1")]
		public void AddCanvas(Canvas canvas)
		{
		/* --- GHIDRA: AddCanvas ---
		void ScreenAdaptation_Scale_GameScaler__AddCanvas(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5b80e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_Canvas__Remove__);
		    DAT_ram_00a5b80e = '\x01';
		  }
		  uVar1 = Unity_Services_Analytics_AnalyticsService__get_Instance
		                    (*(undefined4 *)(param1 + 0x1c),param2,
		                     Method_System_Collections_Generic_HashSet_Canvas__Remove__);
		  *(char *)(param1 + 0x20) = (char)uVar1;
		  return;
		}
		*/

		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x5AF2", Offset = "0x5AF2", VA = "0x5AF2")]
		public void RemoveCanvas(Canvas canvas)
		{
		/* --- GHIDRA: RemoveCanvas ---
		void ScreenAdaptation_Scale_GameScaler__RemoveCanvas(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 param5;
		  undefined4 param4;
		  undefined4 param3;
		  
		  if (DAT_ram_00a5b80f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__int__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_ScreenAdaptation_Scale_GameScaler_InstanceOnAppSizeChangedEvent__);
		    Mono_Security_ASN1__get_Item(&ScreenAdaptation_WebGL_ScreenScale_TypeInfo);
		    Mono_Security_ASN1__get_Item(&ScreenAdaptation_Common_Settings_TypeInfo);
		    DAT_ram_00a5b80f = '\x01';
		  }
		  if (DAT_ram_00a5b8f3 == '\0') {
		    Mono_Security_ASN1__get_Item(&ScreenAdaptation_Common_AppSize_TypeInfo);
		    DAT_ram_00a5b8f3 = '\x01';
		  }
		  uVar2 = **(undefined4 **)(ScreenAdaptation_Common_AppSize_TypeInfo + 0x5c);
		  if (*(int *)(ScreenAdaptation_Common_Settings_TypeInfo + 0x74) == 0) {
		    func_ii_306000(ScreenAdaptation_Common_Settings_TypeInfo);
		  }
		  param5 = *(undefined4 *)(param1 + 0x1c);
		  param4 = *(undefined4 *)(param1 + 0x18);
		  param3 = **(undefined4 **)(ScreenAdaptation_Common_Settings_TypeInfo + 0x5c);
		  uVar1 = unnamed_function_1417(ScreenAdaptation_WebGL_ScreenScale_TypeInfo);
		  UnitySourceGeneratedAssemblyMonoScriptTypes_v1___ctor(uVar1,uVar2,param3,param4,param5,0);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  if (DAT_ram_00a5b8f3 == '\0') {
		    Mono_Security_ASN1__get_Item(&ScreenAdaptation_Common_AppSize_TypeInfo);
		    DAT_ram_00a5b8f3 = '\x01';
		  }
		  uVar1 = **(undefined4 **)(ScreenAdaptation_Common_AppSize_TypeInfo + 0x5c);
		  uVar2 = unnamed_function_1417(System_Action_int__int__TypeInfo);
		  System_Action_int__HierarchyNode___Invoke
		            (uVar2,param1,Method_ScreenAdaptation_Scale_GameScaler_InstanceOnAppSizeChangedEvent__,0
		            );
		  ScreenAdaptation_Common_AbstractScreenScale__SetScreenSize(uVar1,uVar2,0);
		  if (DAT_ram_00a5b8f3 == '\0') {
		    Mono_Security_ASN1__get_Item(&ScreenAdaptation_Common_AppSize_TypeInfo);
		    DAT_ram_00a5b8f3 = '\x01';
		  }
		  *(undefined1 *)(param1 + 0x21) = 1;
		  return;
		}
		*/

		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x5AF3", Offset = "0x5AF3", VA = "0x5AF3")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void ScreenAdaptation_Scale_GameScaler__Start
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  *(undefined1 *)(param1 + 0x21) = 1;
		  return;
		}
		*/

		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x5AF4", Offset = "0x5AF4", VA = "0x5AF4")]
		private void InstanceOnAppSizeChangedEvent(int w, int h)
		{
		/* --- GHIDRA: InstanceOnAppSizeChangedEvent ---
		void ScreenAdaptation_Scale_GameScaler__InstanceOnAppSizeChangedEvent(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if ((*(char *)(param1 + 0x20) != '\0') || (*(char *)(param1 + 0x21) != '\0')) {
		    *(undefined2 *)(param1 + 0x20) = 0;
		    param1_00 = *(undefined4 *)(param1 + 0x14);
		    if (DAT_ram_00a5b8f3 == '\0') {
		      Mono_Security_ASN1__get_Item(&ScreenAdaptation_Common_AppSize_TypeInfo);
		      DAT_ram_00a5b8f3 = '\x01';
		    }
		    ScreenAdaptation_Common_AbstractScreenScale___ctor
		              (param1_00,
		               (float)*(int *)(**(int **)(ScreenAdaptation_Common_AppSize_TypeInfo + 0x5c) + 0x14),
		               (float)*(int *)(**(int **)(ScreenAdaptation_Common_AppSize_TypeInfo + 0x5c) + 0x18),0
		              );
		    iVar1 = *(int *)(param1 + 0x10);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x5AF5", Offset = "0x5AF5", VA = "0x5AF5")]
		private void Update()
		{
		/* --- GHIDRA: Update ---
		void ScreenAdaptation_Scale_GameScaler__Update(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5b810 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__int__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_ScreenAdaptation_Scale_GameScaler_InstanceOnAppSizeChangedEvent__);
		    DAT_ram_00a5b810 = '\x01';
		  }
		  if (DAT_ram_00a5b8f3 == '\0') {
		    Mono_Security_ASN1__get_Item(&ScreenAdaptation_Common_AppSize_TypeInfo);
		    DAT_ram_00a5b8f3 = '\x01';
		  }
		  param1_01 = **(undefined4 **)(ScreenAdaptation_Common_AppSize_TypeInfo + 0x5c);
		  param1_00 = unnamed_function_1417(System_Action_int__int__TypeInfo);
		  System_Action_int__HierarchyNode___Invoke
		            (param1_00,param1,
		             Method_ScreenAdaptation_Scale_GameScaler_InstanceOnAppSizeChangedEvent__,0);
		  ScreenAdaptation_Common_AppSize__add_AppSizeChangedEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x5AF6", Offset = "0x5AF6", VA = "0x5AF6")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void ScreenAdaptation_Scale_GameScaler__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5b811 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_Camera___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_Canvas___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_HashSet_Camera__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_HashSet_Canvas__TypeInfo);
		    DAT_ram_00a5b811 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_HashSet_Camera__TypeInfo);
		  func_ii_7115(uVar1,Method_System_Collections_Generic_HashSet_Camera___ctor__);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_HashSet_Canvas__TypeInfo);
		  func_ii_7115(uVar1,Method_System_Collections_Generic_HashSet_Canvas___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x5AF7", Offset = "0x5AF7", VA = "0x5AF7")]
		public GameScaler()
		{
		/* --- GHIDRA: .ctor ---
		void ScreenAdaptation_Scale_GameScaler___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  iVar2 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      uVar3 = *(undefined4 *)(iVar2 + iVar1 * 4 + 0x10);
		      if (DAT_ram_00a5b8f1 == '\0') {
		        Mono_Security_ASN1__get_Item(&ScreenAdaptation_Scale_GameScaler_TypeInfo);
		        DAT_ram_00a5b8f1 = '\x01';
		      }
		      iVar4 = **(int **)(ScreenAdaptation_Scale_GameScaler_TypeInfo + 0x5c);
		      if (DAT_ram_00a5b80c == '\0') {
		        Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_Camera__Remove__);
		        DAT_ram_00a5b80c = '\x01';
		      }
		      uVar3 = Unity_Services_Analytics_AnalyticsService__get_Instance
		                        (*(undefined4 *)(iVar4 + 0x18),uVar3,
		                         Method_System_Collections_Generic_HashSet_Camera__Remove__);
		      *(char *)(iVar4 + 0x20) = (char)uVar3;
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  iVar2 = *(int *)(param1 + 0x14);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      uVar3 = *(undefined4 *)(iVar2 + iVar1 * 4 + 0x10);
		      if (DAT_ram_00a5b8f1 == '\0') {
		        Mono_Security_ASN1__get_Item(&ScreenAdaptation_Scale_GameScaler_TypeInfo);
		        DAT_ram_00a5b8f1 = '\x01';
		      }
		      iVar4 = **(int **)(ScreenAdaptation_Scale_GameScaler_TypeInfo + 0x5c);
		      if (DAT_ram_00a5b80e == '\0') {
		        Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_Canvas__Remove__);
		        DAT_ram_00a5b80e = '\x01';
		      }
		      uVar3 = Unity_Services_Analytics_AnalyticsService__get_Instance
		                        (*(undefined4 *)(iVar4 + 0x1c),uVar3,
		                         Method_System_Collections_Generic_HashSet_Canvas__Remove__);
		      *(char *)(iVar4 + 0x20) = (char)uVar3;
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0400024F RID: 591
		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x14")]
		private AbstractScreenScale _screenScalerImpl;

		// Token: 0x04000250 RID: 592
		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x18")]
		private readonly HashSet<Camera> _cameras;

		// Token: 0x04000251 RID: 593
		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x1C")]
		private readonly HashSet<Canvas> _canvases;

		// Token: 0x04000252 RID: 594
		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x20")]
		private bool _contentChanged;

		// Token: 0x04000253 RID: 595
		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x21")]
		private bool _appSizeChanged;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Instance ---
		void ScreenAdaptation_Scale_GameScaler__get_Instance(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5b807 == '\0') {
		    Mono_Security_ASN1__get_Item(&ScreenAdaptation_Scale_GameScaler_TypeInfo);
		    DAT_ram_00a5b807 = '\x01';
		  }
		  **(undefined4 **)(ScreenAdaptation_Scale_GameScaler_TypeInfo + 0x5c) = param1;
		  return;
		}
		*/


		/* --- GHIDRA: set_Instance ---
		void ScreenAdaptation_Scale_GameScaler__set_Instance(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5b808 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5b808 = '\x01';
		  }
		  if (DAT_ram_00a5b8f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&ScreenAdaptation_Scale_GameScaler_TypeInfo);
		    DAT_ram_00a5b8f1 = '\x01';
		  }
		  uVar3 = **(undefined4 **)(ScreenAdaptation_Scale_GameScaler_TypeInfo + 0x5c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar3,0,0);
		  if (iVar1 == 0) {
		    if (DAT_ram_00a5b8f2 == '\0') {
		      Mono_Security_ASN1__get_Item(&ScreenAdaptation_Scale_GameScaler_TypeInfo);
		      DAT_ram_00a5b8f2 = '\x01';
		    }
		    **(undefined4 **)(ScreenAdaptation_Scale_GameScaler_TypeInfo + 0x5c) = param1;
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1,0);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    UnityEngine_Object__FindObjectsByType(uVar3,0);
		    return;
		  }
		  uVar3 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar3 = unnamed_function_1417(uVar3);
		  uVar2 = unnamed_function_2232(&StringLiteral_11988);
		  System_String__Concat(uVar3,uVar2,0);
		  uVar2 = unnamed_function_2232(&Method_ScreenAdaptation_Scale_GameScaler_Awake__);
		  func_ii_1050(uVar3,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_GameContentScaledEvent ---
		void ScreenAdaptation_Scale_GameScaler__add_GameContentScaledEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a5b80a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5b80a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x10,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_GameContentScaledEvent ---
		void ScreenAdaptation_Scale_GameScaler__remove_GameContentScaledEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5b80b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_Camera__Add__);
		    DAT_ram_00a5b80b = '\x01';
		  }
		  uVar1 = System_Collections_Generic_HashSet_object___Clear
		                    (*(undefined4 *)(param1 + 0x18),param2,
		                     Method_System_Collections_Generic_HashSet_Camera__Add__);
		  *(char *)(param1 + 0x20) = (char)uVar1;
		  return;
		}
		*/

}
