using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Combat.Control;
using Il2CppDummyDll;
using UnityEngine;
using Utils;

namespace Gameplay.Combat.View.Animations
{
	// Token: 0x0200097C RID: 2428
	[Token(Token = "0x200097C")]
	public class CombatAnimation : ICombatAnimation, IDisposable
	{
		// Token: 0x14000185 RID: 389
		// (add) Token: 0x060039CC RID: 14796 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060039CD RID: 14797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000185")]
		public event Action<CombatAnimation.IContent> OnAnimExecuteEvent
		{
			[Token(Token = "0x60039CC")]
			[Address(RVA = "0x8959", Offset = "0x8959", VA = "0x8959", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60039CD")]
			[Address(RVA = "0x895A", Offset = "0x895A", VA = "0x895A", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x060039CE RID: 14798 RVA: 0x0000B8B0 File Offset: 0x00009AB0
		// (set) Token: 0x060039CF RID: 14799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B58")]
		public bool ScreenConvIsPause
		{
			[Token(Token = "0x60039CE")]
			[Address(RVA = "0x895B", Offset = "0x895B", VA = "0x895B")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60039CF")]
			[Address(RVA = "0x895C", Offset = "0x895C", VA = "0x895C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x060039D0 RID: 14800 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060039D1 RID: 14801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B59")]
		public Conveyor ScreenConv
		{
			[Token(Token = "0x60039D0")]
			[Address(RVA = "0x895D", Offset = "0x895D", VA = "0x895D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60039D1")]
			[Address(RVA = "0x895E", Offset = "0x895E", VA = "0x895E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x060039D2 RID: 14802 RVA: 0x0000B8C8 File Offset: 0x00009AC8
		// (set) Token: 0x060039D3 RID: 14803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B5A")]
		public bool IsDisposed
		{
			[Token(Token = "0x60039D2")]
			[Address(RVA = "0x895F", Offset = "0x895F", VA = "0x895F")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60039D3")]
			[Address(RVA = "0x8960", Offset = "0x8960", VA = "0x8960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060039D4 RID: 14804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039D4")]
		[Address(RVA = "0x8961", Offset = "0x8961", VA = "0x8961")]
		private void ScreenConvPause()
		{
		/* --- GHIDRA: ScreenConvPause ---
		void Gameplay_Combat_View_Animations_CombatAnimation__ScreenConvPause(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  
		  *(undefined1 *)(param1 + 0x14) = 0;
		  param1_00 = *(int *)(param1 + 0x18);
		  if (*(char *)(param1_00 + 8) == '\0') {
		    *(undefined2 *)(param1_00 + 8) = 1;
		    func_ii_7227(param1_00,param1_00);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060039D5 RID: 14805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039D5")]
		[Address(RVA = "0x8962", Offset = "0x8962", VA = "0x8962")]
		private void ScreenConvResume()
		{
		}

		// Token: 0x060039D6 RID: 14806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039D6")]
		[Address(RVA = "0x1CB1", Offset = "0x1CB1", VA = "0x1CB1")]
		public CombatAnimation(CombatAnimationCounter animationCounter, Transform parent, int sortingOrder)
		{
		/* --- GHIDRA: .ctor ---
		int * Gameplay_Combat_View_Animations_CombatAnimation___ctor(int *param1)
		
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

		// Token: 0x060039D7 RID: 14807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039D7")]
		[Address(RVA = "0x8963", Offset = "0x8963", VA = "0x8963")]
		private void ScreenAnimCompleteQueueCallback()
		{
		/* --- GHIDRA: ScreenAnimCompleteQueueCallback ---
		void Gameplay_Combat_View_Animations_CombatAnimation__ScreenAnimCompleteQueueCallback
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint *puVar2;
		  int iVar3;
		  int *piVar4;
		  float fVar5;
		  uint uVar6;
		  undefined8 local_28;
		  undefined4 local_20;
		  float4 local_18;
		  undefined4 local_14;
		  undefined4 uStack_10;
		  float4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57dfb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CombatAnimation_IContent__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_Animations_CombatAnimation_AnimationConvItem_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Animations_CombatAnimation_HandleScreenAnimationOnCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a57dfb = '\x01';
		  }
		  *(undefined1 *)(param1 + 0x14) = 1;
		  iVar3 = *(int *)(param1 + 0x18);
		  if (*(int *)(iVar3 + 0x1c) != 0) {
		    System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_ConfiguredTaskAwaitable_ConfiguredTaskAwaiter__WebRequestStream__WriteChunkTrailer_d__40_
		              (*(int *)(iVar3 + 0x1c),0);
		    System_Threading_CancellationTokenSource__Cancel(*(undefined4 *)(iVar3 + 0x1c),0);
		  }
		  *(undefined2 *)(iVar3 + 8) = 0;
		  *(undefined4 *)(iVar3 + 0x1c) = 0;
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Combat_View_Animations_CombatAnimation_AnimationConvItem_TypeInfo
		                        + 0xb8)) ||
		       (*(int *)(*(int *)(*param2 + 100) +
		                 (uint)*(byte *)(
		                                Gameplay_Combat_View_Animations_CombatAnimation_AnimationConvItem_TypeInfo
		                                + 0xb8) * 4 + -4) !=
		        Gameplay_Combat_View_Animations_CombatAnimation_AnimationConvItem_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param2,Gameplay_Combat_View_Animations_CombatAnimation_AnimationConvItem_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  piVar4 = (int *)param2[4];
		  uVar1 = unnamed_function_1417(System_Action_CombatAnimation_IContent__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Combat_View_Animations_CombatAnimation_HandleScreenAnimationOnCompleteEvent__
		             ,0);
		  iVar3 = *piVar4;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar6 = 0;
		    do {
		      if (Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8)) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e67072;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar6);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,
		                                Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo,0)
		  ;
		code_r0x80e67072:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar4,uVar1,puVar2[1]);
		  uVar6 = 0;
		  piVar4 = (int *)param2[4];
		  iVar3 = *piVar4;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8 + 4) * 8 + iVar3 + 0xe8);
		        goto code_r0x80e670f1;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar6);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,
		                                Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo,5)
		  ;
		code_r0x80e670f1:
		  uVar6 = 0;
		  uVar1 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  func_ii_20513(&local_c,uVar1,0);
		  piVar4 = (int *)param2[4];
		  iVar3 = *piVar4;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8 + 4) * 8 + iVar3 + 0xf0);
		        goto code_r0x80e6718d;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar6);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,
		                                Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo,6)
		  ;
		code_r0x80e6718d:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  if (iVar3 == 0) {
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Math_TypeInfo);
		    }
		    fVar5 = -ABS((float)local_c);
		  }
		  else {
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Math_TypeInfo);
		    }
		    fVar5 = ABS((float)local_c);
		  }
		  uVar6 = 0;
		  piVar4 = (int *)param2[4];
		  iVar3 = *piVar4;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8 + 4) * 8 + iVar3 + 0xe8);
		        goto code_r0x80e6724c;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar6);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,
		                                Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo,5)
		  ;
		code_r0x80e6724c:
		  uVar1 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  local_14 = (undefined4)local_8;
		  uStack_10 = (undefined4)((ulonglong)local_8 >> 0x20);
		  local_20 = uStack_10;
		  local_28 = CONCAT44(local_14,fVar5);
		  uVar6 = 0;
		  local_18 = (float4)fVar5;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(uVar1,&local_28,0);
		  piVar4 = (int *)param2[4];
		  iVar3 = *piVar4;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x80e67300;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar6);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,
		                                Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo,2)
		  ;
		code_r0x80e67300:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar6 = 0;
		  piVar4 = (int *)param2[4];
		  iVar3 = *piVar4;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8 + 4) * 8 + iVar3 + 0xe0);
		        goto code_r0x80e67383;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar6);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,
		                                Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo,4)
		  ;
		code_r0x80e67383:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar4,0,puVar2[1]);
		  iVar3 = *(int *)(param1 + 8);
		  if (iVar3 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),param2[4],*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060039D8 RID: 14808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039D8")]
		[Address(RVA = "0x8964", Offset = "0x8964", VA = "0x8964")]
		private void ScreenAnimExecuteCallback(IConveyorItem convItem)
		{
		/* --- GHIDRA: ScreenAnimExecuteCallback ---
		void Gameplay_Combat_View_Animations_CombatAnimation__ScreenAnimExecuteCallback
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  int iVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57dfc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CombatAnimation_IContent__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Animations_CombatAnimation_HandleScreenAnimationOnCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo)
		    ;
		    DAT_ram_00a57dfc = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Action_CombatAnimation_IContent__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Combat_View_Animations_CombatAnimation_HandleScreenAnimationOnCompleteEvent__
		             ,0);
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x80e6748a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,
		                                Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo,1)
		  ;
		code_r0x80e6748a:
		  (**(code **)((ulonglong)*puVar2 * 4))(param2,param1_00,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd8);
		        goto code_r0x80e67506;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,
		                                Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo,3)
		  ;
		code_r0x80e67506:
		  (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  iVar4 = *(int *)(param1 + 0x24);
		  iVar3 = *(int *)(iVar4 + 8) + -1;
		  *(int *)(iVar4 + 8) = iVar3;
		  if ((iVar3 == 0) && (iVar4 = *(int *)(iVar4 + 0xc), iVar4 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		              (*(undefined4 *)(iVar4 + 0x20),*(undefined4 *)(iVar4 + 0x14));
		  }
		  if (*(char *)(param1 + 0x1c) == '\0') {
		    *(undefined1 *)(param1 + 0x14) = 0;
		    iVar4 = *(int *)(param1 + 0x18);
		    if (*(char *)(iVar4 + 8) == '\0') {
		      *(undefined2 *)(iVar4 + 8) = 1;
		      func_ii_7227(iVar4,iVar4);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060039D9 RID: 14809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039D9")]
		[Address(RVA = "0x8965", Offset = "0x8965", VA = "0x8965")]
		private void HandleScreenAnimationOnCompleteEvent(CombatAnimation.IContent content)
		{
		/* --- GHIDRA: HandleScreenAnimationOnCompleteEvent ---
		undefined4
		Gameplay_Combat_View_Animations_CombatAnimation__HandleScreenAnimationOnCompleteEvent
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  undefined4 uVar2;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57dfd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_OpToken_CombatAnimation_IContent__CombatAnimation_IContent___TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Animations_CombatAnimationLoader_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_Animations_CombatAnimation_HandleLoadFail__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_Animations_CombatAnimation_HandleLoadSuccess__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__OpToken_CombatAnimation_IContent__CombatAnimation_IContent___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__OpToken_CombatAnimation_IContent__CombatAnimation_IContent___TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_LinkedList_OpToken_CombatAnimation_IContent__CombatAnimation_IContent___AddFirst__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Utils_OpToken_CombatAnimation_IContent__CombatAnimation_IContent__AddHandlers__
		              );
		    DAT_ram_00a57dfd = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                    (*(undefined4 *)(param1 + 0xc),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_string__OpToken_CombatAnimation_IContent__CombatAnimation_IContent___TryGetValue__
		                    );
		  if (iVar1 == 0) {
		    uVar2 = *(undefined4 *)(param1 + 0x28);
		    iVar1 = unnamed_function_1417(Gameplay_Combat_View_Animations_CombatAnimationLoader_TypeInfo);
		    *(undefined4 *)(iVar1 + 0x18) = uVar2;
		    uVar2 = Gameplay_Combat_View_Animations_CombatAnimationLoader___ctor
		                      (iVar1,param2,*(undefined4 *)(param1 + 0x20),param1);
		    param1_00 = unnamed_function_1417
		                          (
		                          System_Action_OpToken_CombatAnimation_IContent__CombatAnimation_IContent___TypeInfo
		                          );
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,
		               Method_Gameplay_Combat_View_Animations_CombatAnimation_HandleLoadSuccess__,0);
		    param1_01 = unnamed_function_1417
		                          (
		                          System_Action_OpToken_CombatAnimation_IContent__CombatAnimation_IContent___TypeInfo
		                          );
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_01,param1,
		               Method_Gameplay_Combat_View_Animations_CombatAnimation_HandleLoadFail__,0);
		    uVar2 = Gameplay_FeedbackForm_Service_FeedbackFormService__SubmitFormInternal
		                      (uVar2,param1_00,param1_01,
		                       Method_Utils_OpToken_CombatAnimation_IContent__CombatAnimation_IContent__AddHandlers__
		                      );
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___Conveyor__Execute_d__14_
		              (*(undefined4 *)(param1 + 0x10),uVar2,
		               Method_System_Collections_Generic_LinkedList_OpToken_CombatAnimation_IContent__CombatAnimation_IContent___AddFirst__
		              );
		    System_Reflection_FieldInfo__get_IsStatic
		              (*(undefined4 *)(param1 + 0xc),param2,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__OpToken_CombatAnimation_IContent__CombatAnimation_IContent___Add__
		              );
		    local_4 = uVar2;
		  }
		  return local_4;
		}
		*/

		}

		// Token: 0x060039DA RID: 14810 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60039DA")]
		[Address(RVA = "0x8966", Offset = "0x8966", VA = "0x8966", Slot = "6")]
		public OpToken<CombatAnimation.IContent, CombatAnimation.IContent> Load(string path)
		{
		/* --- GHIDRA: Load ---
		void Gameplay_Combat_View_Animations_CombatAnimation__Load
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param3_00;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57dfe == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_OpToken_CombatAnimation_IContent__CombatAnimation_IContent___TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Utils_OpToken_CombatAnimation_IContent__CombatAnimation_IContent__AddResultHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Animations_CombatAnimation___c__DisplayClass29_0__Append_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_Animations_CombatAnimation___c__DisplayClass29_0_TypeInfo);
		    DAT_ram_00a57dfe = '\x01';
		  }
		  param3_00 = unnamed_function_1417
		                        (
		                        Gameplay_Combat_View_Animations_CombatAnimation___c__DisplayClass29_0_TypeInfo
		                        );
		  *(undefined4 *)(param3_00 + 0xc) = param1;
		  *(undefined1 *)(param3_00 + 8) = (undefined1)param3;
		  param1_00 = Gameplay_Combat_View_Animations_CombatAnimation__HandleScreenAnimationOnCompleteEvent
		                        (param1,param2,param3_00);
		  param1_01 = unnamed_function_1417
		                        (
		                        System_Action_OpToken_CombatAnimation_IContent__CombatAnimation_IContent___TypeInfo
		                        );
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param3_00,
		             Method_Gameplay_Combat_View_Animations_CombatAnimation___c__DisplayClass29_0__Append_b__0__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,
		             Method_Utils_OpToken_CombatAnimation_IContent__CombatAnimation_IContent__AddResultHandler__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060039DB RID: 14811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039DB")]
		[Address(RVA = "0x8967", Offset = "0x8967", VA = "0x8967", Slot = "7")]
		public void Append(string path, bool isLeft)
		{
		/* --- GHIDRA: Append ---
		void Gameplay_Combat_View_Animations_CombatAnimation__Append
		               (int param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a57e00 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Animations_CombatAnimationLoader_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__OpToken_CombatAnimation_IContent__CombatAnimation_IContent___ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__OpToken_CombatAnimation_IContent__CombatAnimation_IContent___Remove__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_LinkedList_OpToken_CombatAnimation_IContent__CombatAnimation_IContent___Remove__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_OpToken_CombatAnimation_IContent__CombatAnimation_IContent__get_Fault__
		              );
		    DAT_ram_00a57e00 = '\x01';
		  }
		  if (param2[2] != 4) {
		    param1_00 = (int *)param2[9];
		    if (param1_00 != (int *)0x0) {
		      if (((uint)*(byte *)(*param1_00 + 0xb8) <
		           (uint)*(byte *)(Gameplay_Combat_View_Animations_CombatAnimationLoader_TypeInfo + 0xb8))
		         || (*(int *)(*(int *)(*param1_00 + 100) +
		                      (uint)*(byte *)(Gameplay_Combat_View_Animations_CombatAnimationLoader_TypeInfo
		                                     + 0xb8) * 4 + -4) !=
		             Gameplay_Combat_View_Animations_CombatAnimationLoader_TypeInfo)) {
		        System_Activator__CreateInstance
		                  (param1_00,Gameplay_Combat_View_Animations_CombatAnimationLoader_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = System_Xml_Schema_SchemaInfo__get_Notations
		                      (*(undefined4 *)(param1 + 0xc),param1_00[3],
		                       Method_System_Collections_Generic_Dictionary_string__OpToken_CombatAnimation_IContent__CombatAnimation_IContent___ContainsKey__
		                      );
		    if (iVar1 != 0) {
		      System_Linq_Enumerable__First_KeyValuePair_object__object__
		                (*(undefined4 *)(param1 + 0xc),param1_00[3],
		                 Method_System_Collections_Generic_Dictionary_string__OpToken_CombatAnimation_IContent__CombatAnimation_IContent___Remove__
		                );
		      Gameplay_Combat_View_Animations_CombatAnimationLoader__get_Transform(param1_00,param2);
		      (**(code **)((ulonglong)*(uint *)(*param2 + 0x108) * 4))
		                (param2,*(undefined4 *)(*param2 + 0x10c));
		    }
		  }
		  System_Net_WebConnection__StartOperation
		            (*(undefined4 *)(param1 + 0x10),param2,
		             Method_System_Collections_Generic_LinkedList_OpToken_CombatAnimation_IContent__CombatAnimation_IContent___Remove__
		            );
		  return;
		}
		*/

		/* --- GHIDRA: Append ---
		void Gameplay_Combat_View_Animations_CombatAnimation__Append
		               (int param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a57e00 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Animations_CombatAnimationLoader_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__OpToken_CombatAnimation_IContent__CombatAnimation_IContent___ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__OpToken_CombatAnimation_IContent__CombatAnimation_IContent___Remove__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_LinkedList_OpToken_CombatAnimation_IContent__CombatAnimation_IContent___Remove__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_OpToken_CombatAnimation_IContent__CombatAnimation_IContent__get_Fault__
		              );
		    DAT_ram_00a57e00 = '\x01';
		  }
		  if (param2[2] != 4) {
		    param1_00 = (int *)param2[9];
		    if (param1_00 != (int *)0x0) {
		      if (((uint)*(byte *)(*param1_00 + 0xb8) <
		           (uint)*(byte *)(Gameplay_Combat_View_Animations_CombatAnimationLoader_TypeInfo + 0xb8))
		         || (*(int *)(*(int *)(*param1_00 + 100) +
		                      (uint)*(byte *)(Gameplay_Combat_View_Animations_CombatAnimationLoader_TypeInfo
		                                     + 0xb8) * 4 + -4) !=
		             Gameplay_Combat_View_Animations_CombatAnimationLoader_TypeInfo)) {
		        System_Activator__CreateInstance
		                  (param1_00,Gameplay_Combat_View_Animations_CombatAnimationLoader_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = System_Xml_Schema_SchemaInfo__get_Notations
		                      (*(undefined4 *)(param1 + 0xc),param1_00[3],
		                       Method_System_Collections_Generic_Dictionary_string__OpToken_CombatAnimation_IContent__CombatAnimation_IContent___ContainsKey__
		                      );
		    if (iVar1 != 0) {
		      System_Linq_Enumerable__First_KeyValuePair_object__object__
		                (*(undefined4 *)(param1 + 0xc),param1_00[3],
		                 Method_System_Collections_Generic_Dictionary_string__OpToken_CombatAnimation_IContent__CombatAnimation_IContent___Remove__
		                );
		      Gameplay_Combat_View_Animations_CombatAnimationLoader__get_Transform(param1_00,param2);
		      (**(code **)((ulonglong)*(uint *)(*param2 + 0x108) * 4))
		                (param2,*(undefined4 *)(*param2 + 0x10c));
		    }
		  }
		  System_Net_WebConnection__StartOperation
		            (*(undefined4 *)(param1 + 0x10),param2,
		             Method_System_Collections_Generic_LinkedList_OpToken_CombatAnimation_IContent__CombatAnimation_IContent___Remove__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060039DC RID: 14812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039DC")]
		[Address(RVA = "0x8968", Offset = "0x8968", VA = "0x8968", Slot = "8")]
		public void Append(CombatAnimation.IContent content)
		{
		}

		// Token: 0x060039DD RID: 14813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039DD")]
		[Address(RVA = "0x8969", Offset = "0x8969", VA = "0x8969")]
		private void HandleLoadFail(OpToken<CombatAnimation.IContent, CombatAnimation.IContent> op)
		{
		/* --- GHIDRA: HandleLoadFail ---
		void Gameplay_Combat_View_Animations_CombatAnimation__HandleLoadFail
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57e01 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_LinkedList_OpToken_CombatAnimation_IContent__CombatAnimation_IContent___Remove__
		              );
		    DAT_ram_00a57e01 = '\x01';
		  }
		  System_Net_WebConnection__StartOperation
		            (*(undefined4 *)(param1 + 0x10),param2,
		             Method_System_Collections_Generic_LinkedList_OpToken_CombatAnimation_IContent__CombatAnimation_IContent___Remove__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060039DE RID: 14814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039DE")]
		[Address(RVA = "0x896A", Offset = "0x896A", VA = "0x896A")]
		private void HandleLoadSuccess(OpToken<CombatAnimation.IContent, CombatAnimation.IContent> op)
		{
		/* --- GHIDRA: HandleLoadSuccess ---
		void Gameplay_Combat_View_Animations_CombatAnimation__HandleLoadSuccess
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a57e02 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_OpToken_CombatAnimation_IContent__CombatAnimation_IContent____
		              );
		    DAT_ram_00a57e02 = '\x01';
		  }
		  iVar2 = func_ii_6295(*(undefined4 *)(param1 + 0x10),
		                       Method_System_Linq_Enumerable_ToArray_OpToken_CombatAnimation_IContent__CombatAnimation_IContent____
		                      );
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      piVar3 = *(int **)(iVar2 + iVar1 * 4 + 0x10);
		      iVar4 = *piVar3;
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0x118) * 4))(piVar3,*(undefined4 *)(iVar4 + 0x11c));
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060039DF RID: 14815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039DF")]
		[Address(RVA = "0x896B", Offset = "0x896B", VA = "0x896B", Slot = "9")]
		public void CancelLoad()
		{
		/* --- GHIDRA: CancelLoad ---
		void Gameplay_Combat_View_Animations_CombatAnimation__CancelLoad(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a57e02 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_OpToken_CombatAnimation_IContent__CombatAnimation_IContent____
		              );
		    DAT_ram_00a57e02 = '\x01';
		  }
		  iVar2 = func_ii_6295(*(undefined4 *)(param1 + 0x10),
		                       Method_System_Linq_Enumerable_ToArray_OpToken_CombatAnimation_IContent__CombatAnimation_IContent____
		                      );
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      piVar3 = *(int **)(iVar2 + iVar1 * 4 + 0x10);
		      iVar4 = *piVar3;
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0x118) * 4))(piVar3,*(undefined4 *)(iVar4 + 0x11c));
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  iVar1 = *(int *)(param1 + 0x18);
		  if (*(int *)(iVar1 + 0x1c) != 0) {
		    System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_ConfiguredTaskAwaitable_ConfiguredTaskAwaiter__WebRequestStream__WriteChunkTrailer_d__40_
		              (*(int *)(iVar1 + 0x1c),0);
		    System_Threading_CancellationTokenSource__Cancel(*(undefined4 *)(iVar1 + 0x1c),0);
		  }
		  *(undefined2 *)(iVar1 + 8) = 0;
		  *(undefined4 *)(iVar1 + 0x1c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060039E0 RID: 14816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039E0")]
		[Address(RVA = "0x896C", Offset = "0x896C", VA = "0x896C", Slot = "10")]
		public void Stop()
		{
		/* --- GHIDRA: Stop ---
		void Gameplay_Combat_View_Animations_CombatAnimation__Stop(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x18);
		  if (DAT_ram_00a57e5f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_IConveyorItem__Clear__);
		    DAT_ram_00a57e5f = '\x01';
		  }
		  System_Collections_Generic_LinkedList_UIRenderDevice_DeviceToFree___AddLast
		            (*(undefined4 *)(iVar1 + 0x18),
		             Method_System_Collections_Generic_LinkedList_IConveyorItem__Clear__);
		  return;
		}
		*/

		}

		// Token: 0x060039E1 RID: 14817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039E1")]
		[Address(RVA = "0x896D", Offset = "0x896D", VA = "0x896D", Slot = "11")]
		public void Reset()
		{
		/* --- GHIDRA: Reset ---
		void Gameplay_Combat_View_Animations_CombatAnimation__Reset(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  int *piVar5;
		  int iVar6;
		  int *piVar7;
		  int *param2_00;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57e03 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__OpToken_CombatAnimation_IContent__CombatAnimation_IContent___Clear__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__OpToken_CombatAnimation_IContent__CombatAnimation_IContent___get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_string__OpToken_CombatAnimation_IContent__CombatAnimation_IContent___Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_string__OpToken_CombatAnimation_IContent__CombatAnimation_IContent___MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_string__OpToken_CombatAnimation_IContent__CombatAnimation_IContent___get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_LinkedList_OpToken_CombatAnimation_IContent__CombatAnimation_IContent___Clear__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Utils_OpToken_CombatAnimation_IContent__CombatAnimation_IContent__get_Result__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_string__OpToken_CombatAnimation_IContent__CombatAnimation_IContent___GetEnumerator__
		              );
		    DAT_ram_00a57e03 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 0xc),
		                     Method_System_Collections_Generic_Dictionary_string__OpToken_CombatAnimation_IContent__CombatAnimation_IContent___get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_string__OpToken_CombatAnimation_IContent__CombatAnimation_IContent___GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x1a2,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_string__OpToken_CombatAnimation_IContent__CombatAnimation_IContent___MoveNext__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e67fbf;
		    }
		    if (iVar3 == 0) goto code_r0x80e68015;
		    piVar5 = local_8._4_4_;
		    param2_00 = (int *)local_8._4_4_[8];
		    if (param2_00 != (int *)0x0) {
		      iVar6 = *param2_00;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		          if (System_IDisposable_TypeInfo == *piVar7) {
		            puVar4 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		            goto code_r0x80e67f1b;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,param2_00,
		                          System_IDisposable_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) break;
		code_r0x80e67f1b:
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vii(*puVar4,param2_00,puVar4[1]);
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    iVar6 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(*(undefined4 *)(iVar6 + 0x108),piVar5,*(undefined4 *)(iVar6 + 0x10c));
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e67fbf:
		  iVar6 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar3) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80e68015:
		      DAT_ram_009d3e38 = 0;
		      iVar6 = *(int *)(param1 + 0x18);
		      if (DAT_ram_00a57e5f == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Method_System_Collections_Generic_LinkedList_IConveyorItem__Clear__);
		        DAT_ram_00a57e5f = '\x01';
		      }
		      System_Collections_Generic_LinkedList_UIRenderDevice_DeviceToFree___AddLast
		                (*(undefined4 *)(iVar6 + 0x18),
		                 Method_System_Collections_Generic_LinkedList_IConveyorItem__Clear__);
		      iVar6 = *(int *)(param1 + 0x18);
		      if (*(int *)(iVar6 + 0x1c) != 0) {
		        System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_ConfiguredTaskAwaitable_ConfiguredTaskAwaiter__WebRequestStream__WriteChunkTrailer_d__40_
		                  (*(int *)(iVar6 + 0x1c),0);
		        System_Threading_CancellationTokenSource__Cancel(*(undefined4 *)(iVar6 + 0x1c),0);
		      }
		      *(undefined2 *)(iVar6 + 8) = 0;
		      *(undefined4 *)(iVar6 + 0x1c) = 0;
		      if (DAT_ram_00a57e5f == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Method_System_Collections_Generic_LinkedList_IConveyorItem__Clear__);
		        DAT_ram_00a57e5f = '\x01';
		      }
		      System_Collections_Generic_LinkedList_UIRenderDevice_DeviceToFree___AddLast
		                (*(undefined4 *)(iVar6 + 0x18),
		                 Method_System_Collections_Generic_LinkedList_IConveyorItem__Clear__);
		      *(undefined1 *)(iVar6 + 0x14) = 1;
		      *(undefined8 *)(iVar6 + 0xc) = 0;
		      *(undefined4 *)(param1 + 0x18) = 0;
		      *(undefined8 *)(param1 + 0x20) = 0;
		      System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		                (*(undefined4 *)(param1 + 0xc),
		                 Method_System_Collections_Generic_Dictionary_string__OpToken_CombatAnimation_IContent__CombatAnimation_IContent___Clear__
		                );
		      System_Collections_Generic_LinkedList_UIRenderDevice_DeviceToFree___AddLast
		                (*(undefined4 *)(param1 + 0x10),
		                 Method_System_Collections_Generic_LinkedList_OpToken_CombatAnimation_IContent__CombatAnimation_IContent___Clear__
		                );
		      *(undefined1 *)(param1 + 0x1c) = 1;
		      return;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xae,&local_18);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 != 1) {
		    import::env::__resumeException(uVar2);
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

		}

		// Token: 0x060039E2 RID: 14818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039E2")]
		[Address(RVA = "0x896E", Offset = "0x896E", VA = "0x896E", Slot = "12")]
		public void Dispose()
		{
		}

		// Token: 0x04001FFD RID: 8189
		[Token(Token = "0x4001FFD")]
		[FieldOffset(Offset = "0xC")]
		private readonly Dictionary<string, OpToken<CombatAnimation.IContent, CombatAnimation.IContent>> _cache;

		// Token: 0x04001FFE RID: 8190
		[Token(Token = "0x4001FFE")]
		[FieldOffset(Offset = "0x10")]
		private readonly LinkedList<OpToken<CombatAnimation.IContent, CombatAnimation.IContent>> _awaitingLoad;

		// Token: 0x04002002 RID: 8194
		[Token(Token = "0x4002002")]
		[FieldOffset(Offset = "0x20")]
		private Transform _parent;

		// Token: 0x04002003 RID: 8195
		[Token(Token = "0x4002003")]
		[FieldOffset(Offset = "0x24")]
		private CombatAnimationCounter _animationCounter;

		// Token: 0x04002004 RID: 8196
		[Token(Token = "0x4002004")]
		[FieldOffset(Offset = "0x28")]
		public readonly int SortingOrder;

		// Token: 0x0200097D RID: 2429
		[Token(Token = "0x200097D")]
		public interface IContent : IDisposable
		{
			// Token: 0x14000186 RID: 390
			// (add) Token: 0x060039E3 RID: 14819
			// (remove) Token: 0x060039E4 RID: 14820
			[Token(Token = "0x14000186")]
			event Action<CombatAnimation.IContent> OnCompleteEvent;

			// Token: 0x060039E5 RID: 14821
			[Token(Token = "0x60039E5")]
			void Show();

			// Token: 0x060039E6 RID: 14822
			[Token(Token = "0x60039E6")]
			void Hide();

			// Token: 0x060039E7 RID: 14823
			[Token(Token = "0x60039E7")]
			void Play(bool loop);

			// Token: 0x17000B5B RID: 2907
			// (get) Token: 0x060039E8 RID: 14824
			[Token(Token = "0x17000B5B")]
			Transform Transform { [Token(Token = "0x60039E8")] get; }

			// Token: 0x17000B5C RID: 2908
			// (get) Token: 0x060039E9 RID: 14825
			// (set) Token: 0x060039EA RID: 14826
			[Token(Token = "0x17000B5C")]
			bool IsLeft { [Token(Token = "0x60039E9")] get; [Token(Token = "0x60039EA")] set; }
		}

		// Token: 0x0200097E RID: 2430
		[Token(Token = "0x200097E")]
		private class AnimationConvItem : IConveyorItem
		{
			// Token: 0x17000B5D RID: 2909
			// (get) Token: 0x060039EB RID: 14827 RVA: 0x0000B8E0 File Offset: 0x00009AE0
			[Token(Token = "0x17000B5D")]
			public float Duration
			{
				[Token(Token = "0x60039EB")]
				[Address(RVA = "0x896F", Offset = "0x896F", VA = "0x896F", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000B5E RID: 2910
			// (get) Token: 0x060039EC RID: 14828 RVA: 0x0000B8F8 File Offset: 0x00009AF8
			[Token(Token = "0x17000B5E")]
			public float Delay
			{
				[Token(Token = "0x60039EC")]
				[Address(RVA = "0x8970", Offset = "0x8970", VA = "0x8970", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060039ED RID: 14829 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60039ED")]
			[Address(RVA = "0x8971", Offset = "0x8971", VA = "0x8971")]
			public AnimationConvItem(CombatAnimation.IContent content, float duration, float delay)
			{
			}

			// Token: 0x04002007 RID: 8199
			[Token(Token = "0x4002007")]
			[FieldOffset(Offset = "0x10")]
			public readonly CombatAnimation.IContent Content;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_OnAnimExecuteEvent ---
		void Gameplay_Combat_View_Animations_CombatAnimation__add_OnAnimExecuteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57df9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CombatAnimation_IContent__TypeInfo);
		    DAT_ram_00a57df9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_CombatAnimation_IContent__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_CombatAnimation_IContent__TypeInfo), iVar2 == 0
		       )) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
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


		/* --- GHIDRA: set_IsDisposed ---
		void Gameplay_Combat_View_Animations_CombatAnimation__set_IsDisposed(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  *(undefined1 *)(param1 + 0x14) = 1;
		  iVar1 = *(int *)(param1 + 0x18);
		  if (*(int *)(iVar1 + 0x1c) != 0) {
		    System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_ConfiguredTaskAwaitable_ConfiguredTaskAwaiter__WebRequestStream__WriteChunkTrailer_d__40_
		              (*(int *)(iVar1 + 0x1c),0);
		    System_Threading_CancellationTokenSource__Cancel(*(undefined4 *)(iVar1 + 0x1c),0);
		  }
		  *(undefined2 *)(iVar1 + 8) = 0;
		  *(undefined4 *)(iVar1 + 0x1c) = 0;
		  return;
		}
		*/

}
