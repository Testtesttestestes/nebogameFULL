using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Rewards
{
	// Token: 0x02000196 RID: 406
	[Token(Token = "0x2000196")]
	public class RewardsContainer : MonoBehaviour
	{
		// Token: 0x140000E1 RID: 225
		// (add) Token: 0x06000B4E RID: 2894 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000B4F RID: 2895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000E1")]
		public event Action OnDestroyEvent
		{
			[Token(Token = "0x6000B4E")]
			[Address(RVA = "0x5E6D", Offset = "0x5E6D", VA = "0x5E6D")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000B4F")]
			[Address(RVA = "0x5E6E", Offset = "0x5E6E", VA = "0x5E6E")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B50")]
		public virtual T Add<T>(T prefab) where T : AbstractRewardRender
		{
			return null;
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x5E6F", Offset = "0x5E6F", VA = "0x5E6F")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void UI_Rewards_RewardsContainer__Dispose(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x10);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  *(undefined4 *)(param1 + 0x10) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x5E70", Offset = "0x5E70", VA = "0x5E70")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_Rewards_RewardsContainer__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59a0b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AbstractRewardRender___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AbstractRewardRender__TypeInfo);
		    DAT_ram_00a59a0b = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_AbstractRewardRender__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_AbstractRewardRender___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x5E71", Offset = "0x5E71", VA = "0x5E71")]
		public RewardsContainer()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Rewards_RewardsContainer___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a59a0c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a59a0c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x40);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x40,param1_01,param1_00);
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

		// Token: 0x04000520 RID: 1312
		[Token(Token = "0x4000520")]
		[FieldOffset(Offset = "0x14")]
		public Color32 LabelColor;

		// Token: 0x04000521 RID: 1313
		[Token(Token = "0x4000521")]
		[FieldOffset(Offset = "0x18")]
		public Color32 ValueColor;

		// Token: 0x04000522 RID: 1314
		[Token(Token = "0x4000522")]
		[FieldOffset(Offset = "0x1C")]
		public readonly List<AbstractRewardRender> Renderers;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_OnDestroyEvent ---
		void UI_Rewards_RewardsContainer__add_OnDestroyEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a59a0a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a59a0a = '\x01';
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


		/* --- GHIDRA: Add<object> ---
		int UI_Rewards_RewardsContainer__Add_object_
		              (undefined4 param1,undefined4 param2,int *param3,int param4)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int iVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  piVar4 = *(int **)(param4 + 0x1c);
		  if (piVar4 == (int *)0x0) {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentsInChildren_RewardsContainer___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_AbstractRewardRender___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_AbstractRewardRender___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_AbstractRewardRender___);
		    Mono_Security_ASN1__get_Item(&System_Func_AbstractRewardRender__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AbstractRewardRender__AddRange__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AbstractRewardRender___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AbstractRewardRender__TypeInfo);
		    piVar4 = *(int **)(param4 + 0x1c);
		    if (piVar4 == (int *)0x0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param4);
		      piVar4 = *(int **)(param4 + 0x1c);
		    }
		  }
		  iVar5 = *piVar4;
		  if ((*(byte *)(iVar5 + 0xbd) & 1) == 0) {
		    iVar5 = func_ii_1079(iVar5);
		  }
		  iVar5 = unnamed_function_1417(iVar5);
		  *(undefined4 *)(iVar5 + 8) = param2;
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_AbstractRewardRender__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_AbstractRewardRender___ctor__);
		  iVar2 = UnityEngine_Component__GetComponents___Il2CppFullySharedGenericType_
		                    (param1,Method_UnityEngine_Component_GetComponentsInChildren_RewardsContainer___
		                    );
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      uVar6 = *(undefined4 *)(*(int *)(iVar2 + iVar1 * 4 + 0x10) + 0x1c);
		      iVar3 = *(int *)(iVar5 + 0xc);
		      if (iVar3 == 0) {
		        iVar3 = unnamed_function_1417(System_Func_AbstractRewardRender__bool__TypeInfo);
		        System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                  (iVar3,iVar5,*(undefined4 *)(*(int *)(param4 + 0x1c) + 8),0);
		        *(int *)(iVar5 + 0xc) = iVar3;
		      }
		      uVar6 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                        (uVar6,iVar3,Method_System_Linq_Enumerable_Where_AbstractRewardRender___);
		      iVar3 = System_Linq_Enumerable__OrderBy_object__ulong_
		                        (uVar6,Method_System_Linq_Enumerable_Any_AbstractRewardRender___);
		      if (iVar3 != 0) {
		        func_ii_6335(param1_00,uVar6,
		                     Method_System_Collections_Generic_List_AbstractRewardRender__AddRange__);
		      }
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  iVar5 = System_Linq_Enumerable__OrderBy_object__ulong_
		                    (param1_00,Method_System_Linq_Enumerable_Any_AbstractRewardRender___);
		  if (iVar5 == 0) {
		    *param3 = 0;
		  }
		  else {
		    iVar1 = 0;
		    iVar3 = System_Linq_Enumerable__Count_object_
		                      (param1_00,Method_System_Linq_Enumerable_First_AbstractRewardRender___);
		    iVar2 = *(int *)(*(int *)(param4 + 0x1c) + 0x10);
		    if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		      iVar2 = func_ii_1079(iVar2);
		    }
		    if ((iVar3 != 0) && (iVar1 = func_ii_1082(iVar3,iVar2), iVar1 == 0)) {
		      System_Activator__CreateInstance(iVar3,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *param3 = iVar1;
		    iVar2 = *(int *)(*(int *)(param4 + 0x1c) + 0x10);
		    if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		      iVar2 = func_ii_1079(iVar2);
		    }
		    if ((iVar3 != 0) && (iVar1 = func_ii_1082(iVar3,iVar2), iVar1 == 0)) {
		      System_Activator__CreateInstance(iVar3,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return iVar5;
		}
		*/

}
