using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Windows
{
	// Token: 0x02000276 RID: 630
	[Token(Token = "0x2000276")]
	public class PopupController : MonoBehaviour
	{
		// Token: 0x140000F8 RID: 248
		// (add) Token: 0x06000F10 RID: 3856 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000F11 RID: 3857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000F8")]
		public event PopupController.StateChanged OnChangeStateEvent
		{
			[Token(Token = "0x6000F10")]
			[Address(RVA = "0x614F", Offset = "0x614F", VA = "0x614F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000F11")]
			[Address(RVA = "0x6150", Offset = "0x6150", VA = "0x6150")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000F9 RID: 249
		// (add) Token: 0x06000F12 RID: 3858 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000F13 RID: 3859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000F9")]
		public event Action<string, BaseWindowArgs> OnWindowOpenedEvent
		{
			[Token(Token = "0x6000F12")]
			[Address(RVA = "0x6151", Offset = "0x6151", VA = "0x6151")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000F13")]
			[Address(RVA = "0x6152", Offset = "0x6152", VA = "0x6152")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000FA RID: 250
		// (add) Token: 0x06000F14 RID: 3860 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000F15 RID: 3861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000FA")]
		public event Action<string, WindowCloseReason> OnWindowClosedEvent
		{
			[Token(Token = "0x6000F14")]
			[Address(RVA = "0x6153", Offset = "0x6153", VA = "0x6153")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000F15")]
			[Address(RVA = "0x6154", Offset = "0x6154", VA = "0x6154")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000F16 RID: 3862 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000F17 RID: 3863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000218")]
		public BaseWindow TopWindow
		{
			[Token(Token = "0x6000F16")]
			[Address(RVA = "0x6155", Offset = "0x6155", VA = "0x6155")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F17")]
			[Address(RVA = "0x6156", Offset = "0x6156", VA = "0x6156")]
			private set
			{
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000F18 RID: 3864 RVA: 0x000043E0 File Offset: 0x000025E0
		[Token(Token = "0x17000219")]
		public int OpenedWindowsCount
		{
			[Token(Token = "0x6000F18")]
			[Address(RVA = "0x4444", Offset = "0x4444", VA = "0x4444")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F19")]
		public T Show<T>(string windowId, BaseWindowArgs args) where T : BaseWindow
		{
			return null;
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F1A")]
		[Address(RVA = "0x6157", Offset = "0x6157", VA = "0x6157")]
		public BaseWindow Show(string windowId, BaseWindowArgs args, [Optional] Type windowTargetType)
		{
		/* --- GHIDRA: Show ---
		void UI_Windows_PopupController__Show(int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *param1_00;
		  int *param2_00;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a639e3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Last_BaseWindow___);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_IManagedWindow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_LinkedList_BaseWindow__Remove__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_BaseWindow__get_Count__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a639e3 = '\x01';
		  }
		  local_4 = 0;
		  uVar3 = *(undefined4 *)(param1 + 0x30);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar1 = 0;
		  iVar2 = func_ii_3812(uVar3,param2,0);
		  System_Net_WebConnection__StartOperation
		            (*(undefined4 *)(param1 + 0x2c),param2,
		             Method_System_Collections_Generic_LinkedList_BaseWindow__Remove__);
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        param1_00 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x82328575;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  param1_00 = (uint *)func_ii_1080(param2,System_IDisposable_TypeInfo,0);
		code_r0x82328575:
		  (**(code **)((ulonglong)*param1_00 * 4))(param2,param1_00[1]);
		  if (iVar2 != 0) {
		    if (*(int *)(*(int *)(param1 + 0x2c) + 0xc) < 1) {
		      if (DAT_ram_00a639e0 == '\0') {
		        Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		        DAT_ram_00a639e0 = '\x01';
		      }
		      param1_00 = *(uint **)(param1 + 0x30);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar2 = func_ii_3812(param1_00,0,0);
		      if (iVar2 == 0) {
		        *(undefined4 *)(param1 + 0x30) = 0;
		      }
		    }
		    else {
		      param2_00 = (int *)System_Linq_Enumerable__IntersectIterator___Il2CppFullySharedGenericType_
		                                   (*(int *)(param1 + 0x2c),
		                                    Method_System_Linq_Enumerable_Last_BaseWindow___);
		      if (DAT_ram_00a639e0 == '\0') {
		        Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		        DAT_ram_00a639e0 = '\x01';
		      }
		      param1_00 = *(uint **)(param1 + 0x30);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar2 = func_ii_3812(param1_00,param2_00,0);
		      if (iVar2 == 0) {
		        *(int **)(param1 + 0x30) = param2_00;
		      }
		      else {
		        param2_00 = *(int **)(param1 + 0x30);
		      }
		      if (param2_00 != (int *)0x0) {
		        uVar1 = 0;
		        iVar2 = *param2_00;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          do {
		            if (UI_Windows_IManagedWindow_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8))
		            {
		              param1_00 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 +
		                                  0xf0);
		              goto code_r0x8232867b;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		        }
		        param1_00 = (uint *)func_ii_1080(param2_00,UI_Windows_IManagedWindow_TypeInfo,6);
		code_r0x8232867b:
		        (**(code **)((ulonglong)*param1_00 * 4))(param2_00,1,param1_00[1]);
		      }
		    }
		  }
		  UI_Windows_PopupController__OnVisibleChange(param1,param1_00);
		  UI_Windows_PopupController__GetVisibleFullscreenWindowsCount(param1,&local_4,param1_00);
		  iVar2 = *(int *)(param1 + 0x1c);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),local_4,*(undefined4 *)(iVar2 + 0x14));
		  }
		  iVar2 = *(int *)(param1 + 0x24);
		  if (iVar2 != 0) {
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x130) * 4))
		                      (param2,*(undefined4 *)(*param2 + 0x134));
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),uVar3,param3,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		/* --- GHIDRA: Show<object> ---
		uint UI_Windows_PopupController__Show_object_(int param1,undefined4 param2,int param3)
		
		{
		  uint param4;
		  int iVar1;
		  
		  param4 = Google_Protobuf_Collections_RepeatedField_object___GetHashCode
		                     (param1,param2,*(undefined4 *)(*(int *)(*(int *)(param3 + 0x10) + 0x60) + 0x74)
		                     );
		  if (param4 != 0xffffffff) {
		    func_ii_2679(*(undefined4 *)(param1 + 8),param4 + 1,*(undefined4 *)(param1 + 8),param4,
		                 *(int *)(param1 + 0xc) + (param4 ^ 0xffffffff),0);
		    iVar1 = *(int *)(param1 + 0xc) + -1;
		    *(int *)(param1 + 0xc) = iVar1;
		    *(undefined4 *)(*(int *)(param1 + 8) + iVar1 * 4 + 0x10) = 0;
		  }
		  return (uint)(param4 != 0xffffffff);
		}
		*/

			return null;
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1B")]
		[Address(RVA = "0x6158", Offset = "0x6158", VA = "0x6158")]
		public void Close(BaseWindow window, WindowCloseReason windowCloseReason)
		{
		/* --- GHIDRA: Close<__Il2CppFullySharedGenericType> ---
		undefined4
		UI_Windows_PopupController__Close___Il2CppFullySharedGenericType_(undefined4 param1,int param2)
		
		{
		  int iVar1;
		  undefined4 *puVar2;
		  
		  puVar2 = *(undefined4 **)(param2 + 0x1c);
		  if (puVar2 == (undefined4 *)0x0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param2);
		    puVar2 = *(undefined4 **)(param2 + 0x1c);
		  }
		  iVar1 = UI_Windows_PopupController__GetLastWindow_object_(param1,*puVar2);
		  if (*(int *)(iVar1 + 0xc) == 0) {
		    return 0;
		  }
		  return *(undefined4 *)(*(int *)(iVar1 + 0xc) * 4 + iVar1 + 0xc);
		}
		*/

		/* --- GHIDRA: Close<object> ---
		void UI_Windows_PopupController__Close_object_(int param1,undefined4 param2,int param3)
		
		{
		  int iVar1;
		  int *piVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  uint *puVar5;
		  
		  piVar2 = *(int **)(param3 + 0x1c);
		  if (piVar2 == (int *)0x0) {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_BaseWindow___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_BaseWindow___);
		    Mono_Security_ASN1__get_Item(&System_Func_BaseWindow__bool__TypeInfo);
		    piVar2 = *(int **)(param3 + 0x1c);
		    if (piVar2 == (int *)0x0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param3);
		      piVar2 = *(int **)(param3 + 0x1c);
		    }
		  }
		  iVar3 = *piVar2;
		  if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		    iVar3 = func_ii_1079(iVar3);
		  }
		  iVar3 = unnamed_function_1417(iVar3);
		  puVar5 = *(uint **)(*(int *)(param3 + 0x1c) + 4);
		  (**(code **)((ulonglong)*puVar5 * 4))(iVar3,puVar5);
		  uVar4 = *(undefined4 *)(*(int *)(param3 + 0x1c) + 8);
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  iVar1 = 0;
		  uVar4 = func_ii_2734(uVar4,0);
		  *(undefined4 *)(iVar3 + 8) = uVar4;
		  param1_00 = *(undefined4 *)(param1 + 0x2c);
		  uVar4 = unnamed_function_1417(System_Func_BaseWindow__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar4,iVar3,*(undefined4 *)(*(int *)(param3 + 0x1c) + 0xc),0);
		  uVar4 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (param1_00,uVar4,Method_System_Linq_Enumerable_Where_BaseWindow___);
		  iVar3 = func_ii_6295(uVar4,Method_System_Linq_Enumerable_ToArray_BaseWindow___);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      UI_Windows_PopupController__Show(param1,*(undefined4 *)(iVar3 + iVar1 * 4 + 0x10),param2,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar3 + 0xc));
		  }
		  return;
		}
		*/

		/* --- GHIDRA: Close ---
		void UI_Windows_PopupController__Close(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  uint uVar2;
		  int iVar3;
		  int iVar4;
		  uint *puVar5;
		  undefined4 uVar6;
		  int iVar7;
		  int *param1_00;
		  undefined4 param1_01;
		  int *piVar8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a639e5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_LastOrDefault_BaseWindow___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_BaseWindow___);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_BaseWindow__RemoveLast__);
		    DAT_ram_00a639e5 = '\x01';
		  }
		  local_4 = 0;
		  iVar3 = func_ii_6295(*(undefined4 *)(param1 + 0x2c),
		                       Method_System_Linq_Enumerable_ToArray_BaseWindow___);
		  iVar7 = *(int *)(iVar3 + 0xc) + -1;
		  if (-1 < iVar7) {
		    do {
		      param1_00 = *(int **)(iVar3 + iVar7 * 4 + 0x10);
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x148) * 4))
		                        (param1_00,*(undefined4 *)(*param1_00 + 0x14c));
		      if (iVar4 == 0) break;
		      iVar4 = *param1_00;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8);
		          if (System_IDisposable_TypeInfo == *piVar8) {
		            puVar5 = (uint *)(iVar4 + piVar8[1] * 8 + 0xc0);
		            goto code_r0x823289ec;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar2);
		      }
		      puVar5 = (uint *)func_ii_1080(param1_00,System_IDisposable_TypeInfo,0);
		code_r0x823289ec:
		      (**(code **)((ulonglong)*puVar5 * 4))(param1_00,puVar5[1]);
		      System_Collections_Generic_LinkedList_UIRenderDevice_DeviceToFree___RemoveFirst
		                (*(undefined4 *)(param1 + 0x2c),
		                 Method_System_Collections_Generic_LinkedList_BaseWindow__RemoveLast__);
		      iVar4 = *(int *)(param1 + 0x24);
		      if (iVar4 != 0) {
		        uVar6 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x130) * 4))
		                          (param1_00,*(undefined4 *)(*param1_00 + 0x134));
		        (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                  (*(undefined4 *)(iVar4 + 0x20),uVar6,param2,*(undefined4 *)(iVar4 + 0x14));
		      }
		      bVar1 = 0 < iVar7;
		      iVar7 = iVar7 + -1;
		    } while (bVar1);
		  }
		  uVar6 = System_Linq_Enumerable__FirstOrDefault_object_
		                    (*(undefined4 *)(param1 + 0x2c),
		                     Method_System_Linq_Enumerable_LastOrDefault_BaseWindow___);
		  if (DAT_ram_00a639e0 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a639e0 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x30);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar7 = func_ii_3812(param1_01,uVar6,0);
		  if (iVar7 == 0) {
		    *(undefined4 *)(param1 + 0x30) = uVar6;
		  }
		  UI_Windows_PopupController__OnVisibleChange(param1,uVar6);
		  UI_Windows_PopupController__GetVisibleFullscreenWindowsCount(param1,&local_4,uVar6);
		  iVar7 = *(int *)(param1 + 0x1c);
		  if (iVar7 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar7 + 0xc) * 4))
		              (*(undefined4 *)(iVar7 + 0x20),local_4,*(undefined4 *)(iVar7 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1C")]
		public void Close<T>(WindowCloseReason windowCloseReason)
		{
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1D")]
		[Address(RVA = "0x2232", Offset = "0x2232", VA = "0x2232")]
		public void CloseAllForce()
		{
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1E")]
		[Address(RVA = "0x6159", Offset = "0x6159", VA = "0x6159")]
		public void CloseAll(WindowCloseReason windowCloseReason)
		{
		/* --- GHIDRA: CloseAll ---
		int UI_Windows_PopupController__CloseAll(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  undefined4 param1_00;
		  int *piVar6;
		  int iVar7;
		  undefined4 local_4;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a639e6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_SingleOrDefault_BaseWindow___);
		    Mono_Security_ASN1__get_Item(&System_Func_BaseWindow__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_IManagedWindow_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_BaseWindow__AddLast__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_LinkedList_BaseWindow__Remove__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController___c__DisplayClass27_0__BringWindowToFront_b__0__);
		    Mono_Security_ASN1__get_Item(&UI_Windows_PopupController___c__DisplayClass27_0_TypeInfo);
		    DAT_ram_00a639e6 = '\x01';
		  }
		  local_4 = 0;
		  iVar3 = unnamed_function_1417(UI_Windows_PopupController___c__DisplayClass27_0_TypeInfo);
		  *(undefined4 *)(iVar3 + 8) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0x2c);
		  uVar4 = unnamed_function_1417(System_Func_BaseWindow__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar4,iVar3,
		             Method_UI_Windows_PopupController___c__DisplayClass27_0__BringWindowToFront_b__0__,0);
		  iVar3 = UI_SimpleIconValue__set_Value
		                    (param1_00,uVar4,Method_System_Linq_Enumerable_SingleOrDefault_BaseWindow___);
		  if (iVar3 != 0) {
		    System_Net_WebConnection__StartOperation
		              (*(undefined4 *)(param1 + 0x2c),iVar3,
		               Method_System_Collections_Generic_LinkedList_BaseWindow__Remove__);
		    System_Collections_Generic_LinkedList_object____ctor
		              (*(undefined4 *)(param1 + 0x2c),iVar3,
		               Method_System_Collections_Generic_LinkedList_BaseWindow__AddLast__);
		    uVar4 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (iVar3,0);
		    UnityEngine_Transform__get_childCount(uVar4,0);
		    piVar6 = *(int **)(param1 + 0x30);
		    if (piVar6 != (int *)0x0) {
		      iVar1 = *piVar6;
		      if (*(ushort *)(iVar1 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          if (UI_Windows_IManagedWindow_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar2 * 8)) {
		            puVar5 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar2 * 8 + 4) * 8 + iVar1 + 0xf0);
		            goto code_r0x82328c61;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar1 + 0xb6) != uVar2);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar6,UI_Windows_IManagedWindow_TypeInfo,6);
		code_r0x82328c61:
		      (**(code **)((ulonglong)*puVar5 * 4))(piVar6,0,puVar5[1]);
		    }
		    if (DAT_ram_00a639e0 == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		      DAT_ram_00a639e0 = '\x01';
		    }
		    uVar4 = *(undefined4 *)(param1 + 0x30);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = func_ii_3812(uVar4,iVar3,0);
		    if (iVar1 == 0) {
		      *(int *)(param1 + 0x30) = iVar3;
		    }
		    UI_Windows_PopupController__OnVisibleChange(param1,uVar4);
		    uVar2 = 0;
		    piVar6 = *(int **)(param1 + 0x30);
		    iVar1 = *piVar6;
		    if (*(ushort *)(iVar1 + 0xb6) != 0) {
		      do {
		        if (UI_Windows_IManagedWindow_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar2 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar2 * 8 + 4) * 8 + iVar1 + 0xf0);
		          goto code_r0x82328d3a;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar1 + 0xb6) != uVar2);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar6,UI_Windows_IManagedWindow_TypeInfo,6);
		code_r0x82328d3a:
		    (**(code **)((ulonglong)*puVar5 * 4))(piVar6,1,puVar5[1]);
		    UI_Windows_PopupController__GetVisibleFullscreenWindowsCount(param1,&local_4,puVar5);
		    iVar7 = *(int *)(param1 + 0x1c);
		    iVar1 = iVar3;
		    if (iVar7 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar7 + 0xc) * 4))
		                (*(undefined4 *)(iVar7 + 0x20),local_4,*(undefined4 *)(iVar7 + 0x14));
		    }
		  }
		  return iVar1;
		}
		*/

		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F1F")]
		[Address(RVA = "0x615A", Offset = "0x615A", VA = "0x615A")]
		public BaseWindow BringWindowToFront(BaseWindow window)
		{
		/* --- GHIDRA: BringWindowToFront ---
		int UI_Windows_PopupController__BringWindowToFront(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  int iVar2;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a639e7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedListNode_BaseWindow__get_Previous__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedListNode_BaseWindow__get_Value__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_BaseWindow__get_Last__);
		    DAT_ram_00a639e7 = '\x01';
		  }
		  for (param1_00 = UnityEngine_Time__get_frameCount
		                             (*(undefined4 *)(param1 + 0x2c),
		                              Method_System_Collections_Generic_LinkedList_BaseWindow__get_Last__);
		      param1_00 != 0;
		      param1_00 = System_Collections_Generic_LinkedListNode_UIRenderDevice_DeviceToFree___get_Next
		                            (param1_00,
		                             Method_System_Collections_Generic_LinkedListNode_BaseWindow__get_Previous__
		                            )) {
		    iVar2 = **(int **)(param1_00 + 0x14);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x138) * 4))
		                      (*(int **)(param1_00 + 0x14),*(undefined4 *)(iVar2 + 0x13c));
		    iVar1 = iVar2 + iVar1;
		  }
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x000043F8 File Offset: 0x000025F8
		[Token(Token = "0x6000F20")]
		[Address(RVA = "0x615B", Offset = "0x615B", VA = "0x615B")]
		public int GetVisibleFullscreenWindowsCount()
		{
		/* --- GHIDRA: GetVisibleFullscreenWindowsCount ---
		void UI_Windows_PopupController__GetVisibleFullscreenWindowsCount
		               (int param1,int *param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 param1_01;
		  int iVar1;
		  
		  if (DAT_ram_00a639e8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedListNode_BaseWindow__get_Previous__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedListNode_BaseWindow__get_Value__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_BaseWindow__get_Last__);
		    DAT_ram_00a639e8 = '\x01';
		  }
		  *param2 = 0;
		  for (param1_00 = UnityEngine_Time__get_frameCount
		                             (*(undefined4 *)(param1 + 0x2c),
		                              Method_System_Collections_Generic_LinkedList_BaseWindow__get_Last__);
		      param1_00 != 0;
		      param1_00 = System_Collections_Generic_LinkedListNode_UIRenderDevice_DeviceToFree___get_Next
		                            (param1_00,
		                             Method_System_Collections_Generic_LinkedListNode_BaseWindow__get_Previous__
		                            )) {
		    param1_01 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(param1_00 + 0x14),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_01,(uint)(*param2 == 0),0);
		    iVar1 = **(int **)(param1_00 + 0x14);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x138) * 4))
		                      (*(int **)(param1_00 + 0x14),*(undefined4 *)(iVar1 + 0x13c));
		    if (iVar1 != 0) {
		      *param2 = *param2 + 1;
		    }
		  }
		  return;
		}
		*/

			return 0;
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F21")]
		[Address(RVA = "0x615C", Offset = "0x615C", VA = "0x615C")]
		private void ValidateVisibility(out int visibleFullscreenWndCount)
		{
		/* --- GHIDRA: ValidateVisibility ---
		uint UI_Windows_PopupController__ValidateVisibility
		               (int param1,int param2,int *param3,undefined4 param4)
		
		{
		  int iVar1;
		  uint uVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  
		  uVar2 = 1;
		  iVar3 = *(int *)(param1 + 0x18);
		  iVar4 = *(int *)(iVar3 + 0xc);
		  if (iVar4 < 1) {
		    *param3 = 0;
		    return 0;
		  }
		  iVar5 = *(int *)(iVar3 + 0x10);
		  if (param2 != *(int *)(iVar5 + 0x10)) {
		    iVar1 = 0;
		    do {
		      iVar1 = iVar1 + 1;
		      if (iVar4 == iVar1) {
		        iVar5 = 0;
		        break;
		      }
		      iVar5 = *(int *)(iVar3 + iVar1 * 4 + 0x10);
		    } while (param2 != *(int *)(iVar5 + 0x10));
		    uVar2 = (uint)(iVar1 < iVar4);
		  }
		  *param3 = iVar5;
		  return uVar2;
		}
		*/

		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x00004410 File Offset: 0x00002610
		[Token(Token = "0x6000F22")]
		public bool HasOpenWindow<T>() where T : BaseWindow
		{
			return default(bool);
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x00004428 File Offset: 0x00002628
		[Token(Token = "0x6000F23")]
		[Address(RVA = "0x615D", Offset = "0x615D", VA = "0x615D")]
		public bool TryGetLayer(LayerId id, out Layer layer)
		{
		/* --- GHIDRA: TryGetLayer ---
		uint UI_Windows_PopupController__TryGetLayer(int param1,undefined4 *param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a639e9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Last_BaseWindow___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_BaseWindow__get_Count__);
		    DAT_ram_00a639e9 = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(param1 + 0x2c) + 0xc);
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = System_Linq_Enumerable__IntersectIterator___Il2CppFullySharedGenericType_
		                      (*(int *)(param1 + 0x2c),Method_System_Linq_Enumerable_Last_BaseWindow___);
		  }
		  *param2 = uVar2;
		  return (uint)(iVar1 != 0);
		}
		*/

			return default(bool);
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F24")]
		public T[] GetWindows<T>() where T : BaseWindow
		{
			return null;
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F25")]
		public T GetLastWindow<T>() where T : BaseWindow
		{
			return null;
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x00004440 File Offset: 0x00002640
		[Token(Token = "0x6000F26")]
		[Address(RVA = "0x615E", Offset = "0x615E", VA = "0x615E")]
		public bool TryGetLastWindow(out BaseWindow window)
		{
		/* --- GHIDRA: TryGetLastWindow ---
		void UI_Windows_PopupController__TryGetLastWindow(int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  int *piVar6;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a639ea == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Enumerator_BaseWindow__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Enumerator_BaseWindow__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Enumerator_BaseWindow__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_BaseWindow__GetEnumerator__);
		    DAT_ram_00a639ea = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  func_ii_16538(&local_18,*(undefined4 *)(param1 + 0x2c),
		                Method_System_Collections_Generic_LinkedList_BaseWindow__GetEnumerator__);
		  local_20 = 0;
		  local_1c = &local_18;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x355,&local_18,
		                       Method_System_Collections_Generic_LinkedList_Enumerator_BaseWindow__MoveNext__
		                      );
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x82329074;
		    }
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    piVar4 = local_10._4_4_;
		    if (DAT_ram_00a639eb == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&UI_Windows_IManagedWindow_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) break;
		      DAT_ram_00a639eb = '\x01';
		    }
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar6 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		        if (UI_Windows_IManagedWindow_TypeInfo == *piVar6) {
		          puVar3 = (undefined4 *)(piVar6[1] * 8 + iVar5 + 0xf8);
		          goto code_r0x82329015;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar4,
		                        UI_Windows_IManagedWindow_TypeInfo,7);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x82329015:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar3,piVar4,param2,puVar3[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x82329074:
		  iVar5 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 == iVar2) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar2 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		      if (iVar2 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__Unity__IO__Archive__ram_00004472 + 0x1c,&local_20);
		  iVar5 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar5 != 1) {
		    import::env::__resumeException(param1_00);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F27")]
		[Address(RVA = "0x615F", Offset = "0x615F", VA = "0x615F")]
		public void SetVisibleAllWindows(bool value)
		{
		/* --- GHIDRA: SetVisibleAllWindows ---
		void UI_Windows_PopupController__SetVisibleAllWindows
		               (undefined4 param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a639eb == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Windows_IManagedWindow_TypeInfo);
		    DAT_ram_00a639eb = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (UI_Windows_IManagedWindow_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xf8);
		        goto code_r0x823291d7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,UI_Windows_IManagedWindow_TypeInfo,7);
		code_r0x823291d7:
		  (**(code **)((ulonglong)*puVar2 * 4))(param2,param3,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F28")]
		[Address(RVA = "0x6160", Offset = "0x6160", VA = "0x6160")]
		public void SetVisible(BaseWindow openedWindow, bool value)
		{
		/* --- GHIDRA: SetVisible ---
		void UI_Windows_PopupController__SetVisible
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  UI_Windows_PopupController__Show(param1,param2,param3,param3);
		  return;
		}
		*/

		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F29")]
		[Address(RVA = "0x6161", Offset = "0x6161", VA = "0x6161")]
		private void OnWindowClose(BaseWindow baseWindow, WindowCloseReason closeReason)
		{
		/* --- GHIDRA: OnWindowClose ---
		void UI_Windows_PopupController__OnWindowClose
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  UI_Windows_PopupController__CloseAll(param1,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F2A")]
		[Address(RVA = "0x6162", Offset = "0x6162", VA = "0x6162")]
		private void OnWindowBringToFront(BaseWindow baseWindow)
		{
		/* --- GHIDRA: OnWindowBringToFront ---
		void UI_Windows_PopupController__OnWindowBringToFront
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  UI_Windows_PopupController__OnVisibleChange(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F2B")]
		[Address(RVA = "0x6163", Offset = "0x6163", VA = "0x6163")]
		private void OnUpdateBgInWindow(BaseWindow baseWindow)
		{
		/* --- GHIDRA: OnUpdateBgInWindow ---
		void UI_Windows_PopupController__OnUpdateBgInWindow
		               (undefined4 param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a639ec == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Windows_IManagedWindow_TypeInfo);
		    DAT_ram_00a639ec = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (UI_Windows_IManagedWindow_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xf8);
		        goto code_r0x823292a1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,UI_Windows_IManagedWindow_TypeInfo,7);
		code_r0x823292a1:
		  (**(code **)((ulonglong)*puVar2 * 4))(param2,param3,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F2C")]
		[Address(RVA = "0x6164", Offset = "0x6164", VA = "0x6164")]
		private void OnVisibleChange(BaseWindow baseWindow, bool active)
		{
		/* --- GHIDRA: OnVisibleChange ---
		void UI_Windows_PopupController__OnVisibleChange(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  int param1_00;
		  uint *puVar7;
		  uint uVar8;
		  undefined4 param1_01;
		  int *piVar9;
		  int local_28;
		  undefined1 *puStack_24;
		  undefined8 local_20;
		  int local_18;
		  undefined4 local_14;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  iVar2 = 0;
		  if (DAT_ram_00a639ed == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_LayerId__LinkedList_BaseWindow___Add__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_LayerId__LinkedList_BaseWindow___TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_LayerId__LinkedList_BaseWindow___get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_LayerId__LinkedList_BaseWindow___Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_LayerId__LinkedList_BaseWindow___MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_LayerId__LinkedList_BaseWindow___get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_IManagedWindow_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedListNode_BaseWindow__get_Previous__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedListNode_BaseWindow__get_Value__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_BaseWindow__AddFirst__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_LinkedList_BaseWindow__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_LinkedList_BaseWindow___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_BaseWindow__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_BaseWindow__get_Last__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_LinkedList_BaseWindow__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_LayerId__LinkedList_BaseWindow___GetEnumerator__
		              );
		    DAT_ram_00a639ed = '\x01';
		  }
		  local_14 = 0;
		  local_18 = 0;
		  uVar3 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 0x34),
		                     Method_System_Collections_Generic_Dictionary_LayerId__LinkedList_BaseWindow___get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_28,uVar3,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_LayerId__LinkedList_BaseWindow___GetEnumerator__
		            );
		  local_8 = local_20;
		  local_28 = 0;
		  puStack_24 = local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xa1,local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_LayerId__LinkedList_BaseWindow___MoveNext__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x82327fc1;
		    }
		    if (iVar4 == 0) goto code_r0x82328017;
		    DAT_ram_009d3e38 = 0;
		    System_Collections_Generic_LinkedList_UIRenderDevice_DeviceToFree___AddLast
		              (local_8._4_4_,Method_System_Collections_Generic_LinkedList_BaseWindow__Clear__);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar6 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x82327fc1:
		  iVar6 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar4 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_28 = iVar4;
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
		code_r0x82328017:
		      DAT_ram_009d3e38 = 0;
		      for (iVar6 = UnityEngine_Time__get_frameCount
		                             (*(undefined4 *)(param1 + 0x2c),
		                              Method_System_Collections_Generic_LinkedList_BaseWindow__get_Last__);
		          iVar6 != 0;
		          iVar6 = System_Collections_Generic_LinkedListNode_UIRenderDevice_DeviceToFree___get_Next
		                            (iVar6,
		                             Method_System_Collections_Generic_LinkedListNode_BaseWindow__get_Previous__
		                            )) {
		        iVar4 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                          (*(undefined4 *)(param1 + 0x34),
		                           *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x14) + 0x30) + 8),&local_14,
		                           Method_System_Collections_Generic_Dictionary_LayerId__LinkedList_BaseWindow___TryGetValue__
		                          );
		        if (iVar4 == 0) {
		          local_14 = unnamed_function_1417
		                               (System_Collections_Generic_LinkedList_BaseWindow__TypeInfo);
		          func_ii_10812(*(undefined4 *)(param1 + 0x34),
		                        *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x14) + 0x30) + 8),local_14,
		                        Method_System_Collections_Generic_Dictionary_LayerId__LinkedList_BaseWindow___Add__
		                       );
		        }
		        System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___Conveyor__Execute_d__14_
		                  (local_14,*(undefined4 *)(iVar6 + 0x14),
		                   Method_System_Collections_Generic_LinkedList_BaseWindow__AddFirst__);
		      }
		      uVar8 = *(uint *)(*(int *)(param1 + 0x18) + 0xc);
		      if ((int)uVar8 < 1) {
		        iVar6 = *(int *)(param1 + 0x14);
		        uVar8 = 0;
		      }
		      else {
		        do {
		          iVar6 = *(int *)(*(int *)(param1 + 0x18) + (uVar8 - 1) * 4 + 0x10);
		          iVar4 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                            (*(undefined4 *)(param1 + 0x34),*(undefined4 *)(iVar6 + 0x10),&local_18,
		                             Method_System_Collections_Generic_Dictionary_LayerId__LinkedList_BaseWindow___TryGetValue__
		                            );
		          if ((iVar4 != 0) && (iVar4 = *(int *)(local_18 + 0xc), 0 < iVar4)) {
		            param1_00 = UnityEngine_Time__get_frameCount
		                                  (local_18,
		                                   Method_System_Collections_Generic_LinkedList_BaseWindow__get_Last__
		                                  );
		            iVar2 = iVar4;
		            goto joined_r0x82328170;
		          }
		          bVar1 = 1 < uVar8;
		          uVar8 = uVar8 - 1;
		        } while (bVar1);
		        uVar8 = 0;
		      }
		      goto code_r0x82328238;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__Unity__IO__Archive__ram_00004472 + 0x1b,&local_28);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		joined_r0x82328170:
		  iVar2 = iVar2 + -1;
		  if (param1_00 == 0) goto code_r0x82328211;
		  piVar5 = *(int **)(param1_00 + 0x14);
		  iVar4 = *piVar5;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar8 = 0;
		    do {
		      piVar9 = (int *)(*(int *)(iVar4 + 0x58) + uVar8 * 8);
		      if (UI_Windows_IManagedWindow_TypeInfo == *piVar9) {
		        puVar7 = (uint *)(iVar4 + piVar9[1] * 8 + 0xc0);
		        goto code_r0x823281e2;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar8);
		  }
		  puVar7 = (uint *)func_ii_1080(piVar5,UI_Windows_IManagedWindow_TypeInfo,0);
		code_r0x823281e2:
		  iVar4 = (**(code **)((ulonglong)*puVar7 * 4))(piVar5,puVar7[1]);
		  if (iVar4 == 0) goto code_r0x82328211;
		  param1_00 = System_Collections_Generic_LinkedListNode_UIRenderDevice_DeviceToFree___get_Next
		                        (param1_00,
		                         Method_System_Collections_Generic_LinkedListNode_BaseWindow__get_Previous__
		                        );
		  goto joined_r0x82328170;
		code_r0x82328211:
		  uVar8 = (uint)(0 < *(int *)(local_18 + 0xc) && -1 < iVar2);
		code_r0x82328238:
		  param1_01 = *(undefined4 *)(param1 + 0x10);
		  uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (iVar6,0);
		  UnityEngine_Transform__GetParent(param1_01,uVar3,0);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,uVar8,0);
		  UnityEngine_Transform__SetAsLastSibling(*(undefined4 *)(param1 + 0x10),iVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F2D")]
		[Address(RVA = "0x6165", Offset = "0x6165", VA = "0x6165")]
		private void UpdateBg()
		{
		/* --- GHIDRA: UpdateBg ---
		void UI_Windows_PopupController__UpdateBg(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a639ee == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Empty_Layer___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_LayerId__LinkedList_BaseWindow____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_LayerId__LinkedList_BaseWindow___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_LinkedList_BaseWindow___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_LinkedList_BaseWindow__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_UnityInstantiator_TypeInfo);
		    DAT_ram_00a639ee = '\x01';
		  }
		  iVar3 = Method_System_Array_Empty_Layer___;
		  iVar2 = *(int *)(Method_System_Array_Empty_Layer___ + 0x1c);
		  if (iVar2 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(Method_System_Array_Empty_Layer___);
		    iVar2 = *(int *)(iVar3 + 0x1c);
		  }
		  iVar2 = *(int *)(iVar2 + 8);
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  if (*(int *)(iVar2 + 0x74) == 0) {
		    func_ii_306000(iVar2);
		  }
		  iVar3 = *(int *)(*(int *)(iVar3 + 0x1c) + 8);
		  if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		    iVar3 = func_ii_1079(iVar3);
		  }
		  *(undefined4 *)(param1 + 0x18) = **(undefined4 **)(iVar3 + 0x5c);
		  uVar1 = unnamed_function_1417(UI_Windows_UnityInstantiator_TypeInfo);
		  *(undefined4 *)(param1 + 0x28) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_LinkedList_BaseWindow__TypeInfo);
		  *(undefined4 *)(param1 + 0x2c) = uVar1;
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_LayerId__LinkedList_BaseWindow___TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (uVar1,
		             Method_System_Collections_Generic_Dictionary_LayerId__LinkedList_BaseWindow____ctor__);
		  *(undefined4 *)(param1 + 0x34) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F2E")]
		[Address(RVA = "0x6166", Offset = "0x6166", VA = "0x6166")]
		public PopupController()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Windows_PopupController___ctor(int param1,int param2,int param3,undefined4 param4)
		
		{
		  char cVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  uVar3 = *(undefined4 *)(param3 + 4);
		  *(int *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 8) = uVar3;
		  *(int *)(param1 + 0x10) = param2;
		  cVar1 = *(char *)(param3 + 0x2e);
		  *(int *)(param1 + 0x20) = param1;
		  iVar2 = func_ii_4538(param3);
		  if (iVar2 == 0) {
		    if (param2 == 0) {
		      uVar3 = Mono_Unity_CertHelper__AddCertificatesToNativeChain
		                        (0,s_Delegate_to_an_instance_method_c_ram_0005d205);
		      func_ii_1050(uVar3,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		    *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		  }
		  else if (cVar1 == '\x01') {
		    *(char **)(param1 + 0xc) = s___Scripting__Unity__IO__Archive__ram_00004472 + 0x1d;
		  }
		  else {
		    *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		    *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		  }
		  *(char **)(param1 + 0x1c) = s___Scripting__Unity__IO__Archive__ram_00004472 + 0x1e;
		  return;
		}
		*/

		}

		// Token: 0x04000795 RID: 1941
		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RectTransform _windowBG;

		// Token: 0x04000796 RID: 1942
		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Layer _defaultLayer;

		// Token: 0x04000797 RID: 1943
		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Layer[] _layers;

		// Token: 0x0400079B RID: 1947
		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly IInstantiator _instantiator;

		// Token: 0x0400079C RID: 1948
		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private readonly LinkedList<BaseWindow> _openedWindows;

		// Token: 0x0400079D RID: 1949
		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private BaseWindow _topWindow;

		// Token: 0x0400079E RID: 1950
		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private readonly Dictionary<LayerId, LinkedList<BaseWindow>> _windowsByLayers;

		// Token: 0x02000277 RID: 631
		// (Invoke) Token: 0x06000F30 RID: 3888
		[Token(Token = "0x2000277")]
		public delegate void StateChanged(int visibleFullscreenWndCount);
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_OnChangeStateEvent ---
		void UI_Windows_PopupController__add_OnChangeStateEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a639db == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Windows_PopupController_StateChanged_TypeInfo);
		    DAT_ram_00a639db = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (UI_Windows_PopupController_StateChanged_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x1c,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,UI_Windows_PopupController_StateChanged_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_OnChangeStateEvent ---
		void UI_Windows_PopupController__remove_OnChangeStateEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a639dc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__BaseWindowArgs__TypeInfo);
		    DAT_ram_00a639dc = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_string__BaseWindowArgs__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_string__BaseWindowArgs__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
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


		/* --- GHIDRA: add_OnWindowOpenedEvent ---
		void UI_Windows_PopupController__add_OnWindowOpenedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a639dd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__BaseWindowArgs__TypeInfo);
		    DAT_ram_00a639dd = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_string__BaseWindowArgs__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_string__BaseWindowArgs__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
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


		/* --- GHIDRA: remove_OnWindowOpenedEvent ---
		void UI_Windows_PopupController__remove_OnWindowOpenedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a639de == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__WindowCloseReason__TypeInfo);
		    DAT_ram_00a639de = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_string__WindowCloseReason__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_string__WindowCloseReason__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x24,iVar2,param1_00);
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


		/* --- GHIDRA: add_OnWindowClosedEvent ---
		void UI_Windows_PopupController__add_OnWindowClosedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a639df == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__WindowCloseReason__TypeInfo);
		    DAT_ram_00a639df = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_string__WindowCloseReason__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_string__WindowCloseReason__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x24,iVar2,param1_00);
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


		/* --- GHIDRA: get_TopWindow ---
		void UI_Windows_PopupController__get_TopWindow(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a639e0 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a639e0 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x30);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = func_ii_3812(param1_00,param2,0);
		  if (iVar1 == 0) {
		    *(undefined4 *)(param1 + 0x30) = param2;
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_TopWindow ---
		int * UI_Windows_PopupController__set_TopWindow
		                (int param1,undefined4 param2,int param3,undefined4 param4,undefined4 param5)
		
		{
		  int iVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 param1_00;
		  uint *puVar7;
		  int iVar8;
		  int param1_01;
		  int *piVar9;
		  int *param1_02;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a639e2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BaseWindow__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BaseWindow__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BaseWindow__WindowCloseReason__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_IInstantiator_Instantiate_BaseWindow___);
		    Mono_Security_ASN1__get_Item(&UI_Windows_IManagedWindow_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_BaseWindow__AddLast__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_OnUpdateBgInWindow__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_OnVisibleChange__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_OnWindowBringToFront__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_OnWindowClose__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Resources_Load_BaseWindow___);
		    DAT_ram_00a639e2 = '\x01';
		  }
		  local_4 = 0;
		  uVar3 = UnityEngine_Resources__GetBuiltinResource_object_
		                    (param2,Method_UnityEngine_Resources_Load_BaseWindow___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar4 = func_ii_3812(uVar3,0,0);
		  if (iVar4 != 0) {
		    uVar3 = unnamed_function_2232(&Method_UnityEngine_Resources_Load_GameObject___);
		    uVar3 = UnityEngine_Resources__GetBuiltinResource_object_(param2,uVar3);
		    iVar4 = unnamed_function_2232(&UnityEngine_Object_TypeInfo);
		    if (*(int *)(iVar4 + 0x74) == 0) {
		      func_ii_306000(iVar4);
		    }
		    iVar4 = func_ii_3812(uVar3,0,0);
		    if (iVar4 == 0) {
		      uVar5 = unnamed_function_2232(&UI_Windows_NotFoundWindowScript_TypeInfo);
		      uVar5 = unnamed_function_1417(uVar5);
		      UI_Windows_NotFoundWindowScript__get_Message(uVar5,param2,uVar3,uVar3);
		      uVar3 = unnamed_function_2232(&Method_UI_Windows_PopupController_Show__);
		      func_ii_1050(uVar5,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = unnamed_function_2232(&UI_Windows_NotFoundWindowObject_TypeInfo);
		    uVar3 = unnamed_function_1417(uVar3);
		    UI_Windows_NotFoundWindowObject__get_Message(uVar3,param2,uVar3);
		    uVar5 = unnamed_function_2232(&Method_UI_Windows_PopupController_Show__);
		    func_ii_1050(uVar3,uVar5);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  iVar4 = System_Xml_Linq_XNamespace__op_Equality(param4,0,0);
		  if (iVar4 != 0) {
		    uVar5 = unnamed_function_143827(uVar3);
		    if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		      func_ii_306000(DAT_ram_00a669a0);
		    }
		    iVar4 = System_Xml_Linq_XNamespace__op_Equality(uVar5,param4,0);
		    if (iVar4 != 0) {
		      uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (uVar3,0);
		      uVar3 = unnamed_function_143827(uVar3);
		      uVar6 = unnamed_function_2232(&UI_Windows_IncorrectWindowTypeFound_TypeInfo);
		      uVar6 = unnamed_function_1417(uVar6);
		      UI_Windows_IncorrectWindowTypeFound__get_Message(uVar6,param2,uVar5,param4,uVar3,param4);
		      uVar3 = unnamed_function_2232(&Method_UI_Windows_PopupController_Show__);
		      func_ii_1050(uVar6,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar4 = *(int *)(param1 + 0x18);
		  iVar8 = *(int *)(iVar4 + 0xc);
		  if (0 < iVar8) {
		    param1_01 = *(int *)(iVar4 + 0x10);
		    if (*(int *)(param3 + 8) == *(int *)(param1_01 + 0x10)) goto code_r0x82327a05;
		    iVar1 = 0;
		    do {
		      iVar1 = iVar1 + 1;
		      if (iVar8 == iVar1) {
		        param1_01 = 0;
		        break;
		      }
		      param1_01 = *(int *)(iVar4 + iVar1 * 4 + 0x10);
		    } while (*(int *)(param3 + 8) != *(int *)(param1_01 + 0x10));
		    if (iVar1 < iVar8) goto code_r0x82327a05;
		  }
		  param1_01 = *(int *)(param1 + 0x14);
		code_r0x82327a05:
		  piVar9 = *(int **)(param1 + 0x28);
		  uVar2 = 0;
		  uVar5 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1_01,0);
		  iVar4 = Method_UI_Windows_IInstantiator_Instantiate_BaseWindow___;
		  iVar8 = *piVar9;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (*(int *)(Method_UI_Windows_IInstantiator_Instantiate_BaseWindow___ + 0x10) ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		        iVar8 = iVar8 + (*(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (Method_UI_Windows_IInstantiator_Instantiate_BaseWindow___ + 0x2c)) *
		                        8 + 0xc0;
		        goto code_r0x82327a98;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		  }
		  iVar8 = func_ii_1080(piVar9,*(int *)(Method_UI_Windows_IInstantiator_Instantiate_BaseWindow___ +
		                                      0x10),
		                       (uint)*(ushort *)
		                              (Method_UI_Windows_IInstantiator_Instantiate_BaseWindow___ + 0x2c));
		code_r0x82327a98:
		  iVar4 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar8 + 4),iVar4);
		  piVar9 = (int *)(**(code **)((ulonglong)*(uint *)(iVar4 + 4) * 4))(piVar9,uVar3,uVar5,iVar4);
		  System_Collections_Generic_LinkedList_object____ctor
		            (*(undefined4 *)(param1 + 0x2c),piVar9,
		             Method_System_Collections_Generic_LinkedList_BaseWindow__AddLast__);
		  param1_02 = *(int **)(param1 + 0x30);
		  if (param1_02 != (int *)0x0) {
		    iVar4 = *param1_02;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        if (UI_Windows_IManagedWindow_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8)) {
		          puVar7 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8 + 4) * 8 + iVar4 + 0xf0);
		          goto code_r0x82327b3a;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar2);
		    }
		    puVar7 = (uint *)func_ii_1080(param1_02,UI_Windows_IManagedWindow_TypeInfo,6);
		code_r0x82327b3a:
		    (**(code **)((ulonglong)*puVar7 * 4))(param1_02,0,puVar7[1]);
		  }
		  uVar3 = unnamed_function_1417(System_Action_BaseWindow__WindowCloseReason__TypeInfo);
		  System_Action_object__int___Invoke
		            (uVar3,param1,Method_UI_Windows_PopupController_OnWindowClose__,0);
		  uVar5 = unnamed_function_1417(System_Action_BaseWindow__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar5,param1,Method_UI_Windows_PopupController_OnWindowBringToFront__,0);
		  uVar6 = unnamed_function_1417(System_Action_BaseWindow__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar6,param1,Method_UI_Windows_PopupController_OnUpdateBgInWindow__,0);
		  param1_00 = unnamed_function_1417(System_Action_BaseWindow__bool__TypeInfo);
		  System_Action_object__Nullable_ulong____Invoke
		            (param1_00,param1,Method_UI_Windows_PopupController_OnVisibleChange__,0);
		  iVar4 = *piVar9;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (UI_Windows_IManagedWindow_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8)) {
		        puVar7 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x82327c33;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar2);
		  }
		  puVar7 = (uint *)func_ii_1080(piVar9,UI_Windows_IManagedWindow_TypeInfo,4);
		code_r0x82327c33:
		  (**(code **)((ulonglong)*puVar7 * 4))(piVar9,uVar3,uVar5,uVar6,param1_00,puVar7[1]);
		  if (DAT_ram_00a639e0 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a639e0 = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 0x30);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar4 = func_ii_3812(uVar3,piVar9,0);
		  if (iVar4 == 0) {
		    *(int **)(param1 + 0x30) = piVar9;
		  }
		  iVar4 = *piVar9;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (UI_Windows_IManagedWindow_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8)) {
		        puVar7 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x82327d02;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar2);
		  }
		  puVar7 = (uint *)func_ii_1080(piVar9,UI_Windows_IManagedWindow_TypeInfo,5);
		code_r0x82327d02:
		  (**(code **)((ulonglong)*puVar7 * 4))(piVar9,param3,puVar7[1]);
		  UI_Windows_PopupController__OnVisibleChange(param1,puVar7);
		  UI_Windows_PopupController__GetVisibleFullscreenWindowsCount(param1,&local_4,puVar7);
		  iVar4 = *(int *)(param1 + 0x1c);
		  if (iVar4 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		              (*(undefined4 *)(iVar4 + 0x20),local_4,*(undefined4 *)(iVar4 + 0x14));
		  }
		  iVar4 = *(int *)(param1 + 0x20);
		  if (iVar4 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		              (*(undefined4 *)(iVar4 + 0x20),param2,param3,*(undefined4 *)(iVar4 + 0x14));
		  }
		  return piVar9;
		}
		*/


		/* --- GHIDRA: get_OpenedWindowsCount ---
		int UI_Windows_PopupController__get_OpenedWindowsCount(undefined4 param1)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a63c32 == '\0') {
		    Mono_Security_ASN1__get_Item(&DefaultNamespace_SceneAppManager_TypeInfo);
		    DAT_ram_00a63c32 = '\x01';
		  }
		  iVar1 = **(int **)(DefaultNamespace_SceneAppManager_TypeInfo + 0x5c);
		  if (iVar1 == 0) {
		    param1_00 = unnamed_function_1417(DefaultNamespace_SceneAppManager_TypeInfo);
		    DefaultNamespace_SceneAppManager__set_EnableLoad(param1_00,param1_00);
		    **(undefined4 **)(DefaultNamespace_SceneAppManager_TypeInfo + 0x5c) = param1_00;
		    iVar1 = **(int **)(DefaultNamespace_SceneAppManager_TypeInfo + 0x5c);
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: HasOpenWindow<object> ---
		void UI_Windows_PopupController__HasOpenWindow_object_
		               (int param1,undefined4 *param2,undefined4 param3,int param4)
		
		{
		  undefined4 param1_00;
		  int *piVar1;
		  undefined4 param2_00;
		  int iVar2;
		  int param1_01;
		  uint uVar3;
		  
		  piVar1 = *(int **)(param4 + 0x1c);
		  if (piVar1 == (int *)0x0) {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_PopupScheduleManager_ScheduleInfo__Add__);
		    piVar1 = *(int **)(param4 + 0x1c);
		    if (piVar1 == (int *)0x0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param4);
		      piVar1 = *(int **)(param4 + 0x1c);
		    }
		  }
		  param2_00 = *param2;
		  iVar2 = *piVar1;
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  param1_00 = unnamed_function_1417(iVar2);
		  com_unity3d_mediation_LevelPlayInterstitialAd___ctor
		            (param1_00,param2_00,param3,*(undefined4 *)(*(int *)(param4 + 0x1c) + 4));
		  iVar2 = Method_System_Collections_Generic_List_PopupScheduleManager_ScheduleInfo__Add__;
		  param1_01 = *(int *)(param1 + 0x10);
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_01 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_01 + 8) + uVar3 * 4 + 0x10) = param1_00;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,param1_00,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  Core_Gameplay_Managers_PopupScheduleManager__TryOpenWindow(param1,param1_00,0);
		  return;
		}
		*/


		/* --- GHIDRA: GetWindows<object> ---
		uint UI_Windows_PopupController__GetWindows_object_(undefined4 param1,int param2)
		
		{
		  int iVar1;
		  undefined4 *puVar2;
		  
		  puVar2 = *(undefined4 **)(param2 + 0x1c);
		  if (puVar2 == (undefined4 *)0x0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param2);
		    puVar2 = *(undefined4 **)(param2 + 0x1c);
		  }
		  iVar1 = UI_Windows_PopupController__GetLastWindow_object_(param1,*puVar2);
		  return (uint)(*(int *)(iVar1 + 0xc) != 0);
		}
		*/


		/* --- GHIDRA: GetLastWindow<object> ---
		undefined4 UI_Windows_PopupController__GetLastWindow_object_(int param1,int param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  
		  piVar1 = *(int **)(param2 + 0x1c);
		  if (piVar1 == (int *)0x0) {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_BaseWindow___);
		    Mono_Security_ASN1__get_Item(&System_Func_BaseWindow__bool__TypeInfo);
		    piVar1 = *(int **)(param2 + 0x1c);
		    if (piVar1 == (int *)0x0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param2);
		      piVar1 = *(int **)(param2 + 0x1c);
		    }
		  }
		  iVar2 = *piVar1;
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  iVar2 = unnamed_function_1417(iVar2);
		  uVar3 = *(undefined4 *)(*(int *)(param2 + 0x1c) + 8);
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  uVar3 = func_ii_2734(uVar3,0);
		  *(undefined4 *)(iVar2 + 8) = uVar3;
		  param1_00 = *(undefined4 *)(param1 + 0x2c);
		  uVar3 = unnamed_function_1417(System_Func_BaseWindow__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar3,iVar2,*(undefined4 *)(*(int *)(param2 + 0x1c) + 0xc),0);
		  uVar3 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (param1_00,uVar3,Method_System_Linq_Enumerable_Where_BaseWindow___);
		  uVar3 = System_Linq_Enumerable__Cast_DictionaryEntry_
		                    (uVar3,*(undefined4 *)(*(int *)(param2 + 0x1c) + 0x10));
		  uVar3 = func_ii_6295(uVar3,*(undefined4 *)(*(int *)(param2 + 0x1c) + 0x18));
		  return uVar3;
		}
		*/

}
