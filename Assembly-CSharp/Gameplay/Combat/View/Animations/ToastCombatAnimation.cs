using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using Utils;

namespace Gameplay.Combat.View.Animations
{
	// Token: 0x02000987 RID: 2439
	[Token(Token = "0x2000987")]
	public class ToastCombatAnimation : ICombatAnimation, IDisposable
	{
		// Token: 0x1400018E RID: 398
		// (add) Token: 0x06003A33 RID: 14899 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003A34 RID: 14900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400018E")]
		public event Action<CombatAnimation.IContent> OnAnimExecuteEvent
		{
			[Token(Token = "0x6003A33")]
			[Address(RVA = "0x89AF", Offset = "0x89AF", VA = "0x89AF", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003A34")]
			[Address(RVA = "0x89B0", Offset = "0x89B0", VA = "0x89B0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06003A35 RID: 14901 RVA: 0x0000B970 File Offset: 0x00009B70
		// (set) Token: 0x06003A36 RID: 14902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B67")]
		public bool IsPlaying
		{
			[Token(Token = "0x6003A35")]
			[Address(RVA = "0x89B1", Offset = "0x89B1", VA = "0x89B1")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003A36")]
			[Address(RVA = "0x89B2", Offset = "0x89B2", VA = "0x89B2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003A37 RID: 14903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A37")]
		[Address(RVA = "0x89B3", Offset = "0x89B3", VA = "0x89B3")]
		public ToastCombatAnimation(float toastDuration)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Combat_View_Animations_ToastCombatAnimation___ctor
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57e26 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_Animations_ToastCombatAnimation_EmptyContent_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_OpToken_CombatAnimation_IContent__CombatAnimation_IContent__Complete__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_OpToken_CombatAnimation_IContent__CombatAnimation_IContent___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Utils_OpToken_CombatAnimation_IContent__CombatAnimation_IContent__TypeInfo);
		    DAT_ram_00a57e26 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (Utils_OpToken_CombatAnimation_IContent__CombatAnimation_IContent__TypeInfo)
		  ;
		  Gameplay_FeedbackForm_Model_FeedbackFormModel__GetUid
		            (param1_00,
		             Method_Utils_OpToken_CombatAnimation_IContent__CombatAnimation_IContent___ctor__);
		  param2_00 = unnamed_function_1417
		                        (Gameplay_Combat_View_Animations_ToastCombatAnimation_EmptyContent_TypeInfo)
		  ;
		  Core_ExternAppMethods__OpenPaymentWindow
		            (param1_00,param2_00,
		             Method_Utils_OpToken_CombatAnimation_IContent__CombatAnimation_IContent__Complete__);
		  return param1_00;
		}
		*/

		}

		// Token: 0x06003A38 RID: 14904 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003A38")]
		[Address(RVA = "0x89B4", Offset = "0x89B4", VA = "0x89B4", Slot = "6")]
		public OpToken<CombatAnimation.IContent, CombatAnimation.IContent> Load(string path)
		{
			return null;
		}

		// Token: 0x06003A39 RID: 14905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A39")]
		[Address(RVA = "0x89B5", Offset = "0x89B5", VA = "0x89B5", Slot = "7")]
		public void Append(string path, bool isLeft)
		{
		/* --- GHIDRA: Append ---
		void Gameplay_Combat_View_Animations_ToastCombatAnimation__Append
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57e27 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_CombatAnimation_IContent__Enqueue__);
		    DAT_ram_00a57e27 = '\x01';
		  }
		  System_Collections_Generic_Dictionary_Int32Enum__object___TryGetValue
		            (*(undefined4 *)(param1 + 0x10),param2,
		             Method_System_Collections_Generic_Queue_CombatAnimation_IContent__Enqueue__);
		  if (*(char *)(param1 + 0x18) == '\0') {
		    Gameplay_Combat_View_Animations_ToastCombatAnimation__StartAnimation(param1,0,param1);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: Append ---
		void Gameplay_Combat_View_Animations_ToastCombatAnimation__Append
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57e27 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_CombatAnimation_IContent__Enqueue__);
		    DAT_ram_00a57e27 = '\x01';
		  }
		  System_Collections_Generic_Dictionary_Int32Enum__object___TryGetValue
		            (*(undefined4 *)(param1 + 0x10),param2,
		             Method_System_Collections_Generic_Queue_CombatAnimation_IContent__Enqueue__);
		  if (*(char *)(param1 + 0x18) == '\0') {
		    Gameplay_Combat_View_Animations_ToastCombatAnimation__StartAnimation(param1,0,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003A3A RID: 14906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A3A")]
		[Address(RVA = "0x89B6", Offset = "0x89B6", VA = "0x89B6", Slot = "8")]
		public void Append(CombatAnimation.IContent content)
		{
		}

		// Token: 0x06003A3B RID: 14907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A3B")]
		[Address(RVA = "0x89B7", Offset = "0x89B7", VA = "0x89B7", Slot = "9")]
		public void CancelLoad()
		{
		/* --- GHIDRA: CancelLoad ---
		void Gameplay_Combat_View_Animations_ToastCombatAnimation__CancelLoad(int param1,undefined4 param2)
		
		{
		  *(undefined1 *)(param1 + 0x18) = 0;
		  if (*(int *)(param1 + 0x14) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x14),0,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003A3C RID: 14908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A3C")]
		[Address(RVA = "0x89B8", Offset = "0x89B8", VA = "0x89B8", Slot = "10")]
		public void Stop()
		{
		/* --- GHIDRA: Stop ---
		void Gameplay_Combat_View_Animations_ToastCombatAnimation__Stop(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57e28 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_CombatAnimation_IContent__Clear__);
		    DAT_ram_00a57e28 = '\x01';
		  }
		  System_Collections_Generic_Queue_MeshGenerationDeferrer_CallbackInfo____ctor
		            (*(undefined4 *)(param1 + 0x10),
		             Method_System_Collections_Generic_Queue_CombatAnimation_IContent__Clear__);
		  return;
		}
		*/

		}

		// Token: 0x06003A3D RID: 14909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A3D")]
		[Address(RVA = "0x89B9", Offset = "0x89B9", VA = "0x89B9", Slot = "11")]
		public void Reset()
		{
		/* --- GHIDRA: Reset ---
		void Gameplay_Combat_View_Animations_ToastCombatAnimation__Reset(int param1,undefined4 param2)
		
		{
		  *(undefined1 *)(param1 + 0x18) = 0;
		  if (*(int *)(param1 + 0x14) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x14),0,0);
		  }
		  if (DAT_ram_00a57e28 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_CombatAnimation_IContent__Clear__);
		    DAT_ram_00a57e28 = '\x01';
		  }
		  System_Collections_Generic_Queue_MeshGenerationDeferrer_CallbackInfo____ctor
		            (*(undefined4 *)(param1 + 0x10),
		             Method_System_Collections_Generic_Queue_CombatAnimation_IContent__Clear__);
		  return;
		}
		*/

		}

		// Token: 0x06003A3E RID: 14910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A3E")]
		[Address(RVA = "0x89BA", Offset = "0x89BA", VA = "0x89BA", Slot = "12")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Combat_View_Animations_ToastCombatAnimation__Dispose(int param1,undefined4 param2)
		
		{
		  if (*(char *)(param1 + 0x18) == '\0') {
		    Gameplay_Combat_View_Animations_ToastCombatAnimation__StartAnimation(param1,0,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003A3F RID: 14911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A3F")]
		[Address(RVA = "0x89BB", Offset = "0x89BB", VA = "0x89BB")]
		private void StartAnimation()
		{
		/* --- GHIDRA: StartAnimation ---
		void Gameplay_Combat_View_Animations_ToastCombatAnimation__StartAnimation
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int param2_00;
		  int *piVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  float param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a57e29 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_CombatAnimation_IContent__Dequeue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_CombatAnimation_IContent__get_Count__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Animations_ToastCombatAnimation___c__DisplayClass20_0__DelayedCall_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_Animations_ToastCombatAnimation___c__DisplayClass20_0_TypeInfo)
		    ;
		    DAT_ram_00a57e29 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Combat_View_Animations_ToastCombatAnimation___c__DisplayClass20_0_TypeInfo
		                        );
		  *(int *)(param2_00 + 8) = param1;
		  *(undefined1 *)(param1 + 0x18) = 0;
		  if (param2 != (int *)0x0) {
		    uVar1 = 0;
		    iVar5 = *param2;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		          goto code_r0x80e69c75;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param2,
		                                  Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo,
		                                  3);
		code_r0x80e69c75:
		    (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  }
		  if (0 < *(int *)(*(int *)(param1 + 0x10) + 0x14)) {
		    *(undefined1 *)(param1 + 0x18) = 1;
		    uVar1 = 0;
		    piVar2 = (int *)func_ii_7387(*(int *)(param1 + 0x10),
		                                 Method_System_Collections_Generic_Queue_CombatAnimation_IContent__Dequeue__
		                                );
		    *(int **)(param2_00 + 0xc) = piVar2;
		    iVar5 = *piVar2;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		          goto code_r0x80e69d1f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar2,
		                                  Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo,
		                                  2);
		code_r0x80e69d1f:
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		    uVar1 = 0;
		    piVar2 = *(int **)(param2_00 + 0xc);
		    iVar5 = *piVar2;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		          goto code_r0x80e69d9e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar2,
		                                  Gameplay_Combat_View_Animations_CombatAnimation_IContent_TypeInfo,
		                                  4);
		code_r0x80e69d9e:
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar2,0,puVar3[1]);
		    param1_00 = *(float *)(param1 + 0xc);
		    uVar4 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		    DG_Tweening_Color2__op_Multiply
		              (uVar4,param2_00,
		               Method_Gameplay_Combat_View_Animations_ToastCombatAnimation___c__DisplayClass20_0__DelayedCall_b__0__
		               ,0);
		    uVar4 = DG_Tweening_DOVirtual__EasedValue(param1_00,uVar4,1,0);
		    *(undefined4 *)(param1 + 0x14) = uVar4;
		    iVar5 = *(int *)(param1 + 8);
		    if (iVar5 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		                (*(undefined4 *)(iVar5 + 0x20),*(undefined4 *)(param2_00 + 0xc),
		                 *(undefined4 *)(iVar5 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003A40 RID: 14912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A40")]
		[Address(RVA = "0x89BC", Offset = "0x89BC", VA = "0x89BC")]
		private void DelayedCall(CombatAnimation.IContent content)
		{
		}

		// Token: 0x04002024 RID: 8228
		[Token(Token = "0x4002024")]
		[FieldOffset(Offset = "0xC")]
		private readonly float _toastDuration;

		// Token: 0x04002025 RID: 8229
		[Token(Token = "0x4002025")]
		[FieldOffset(Offset = "0x10")]
		private Queue<CombatAnimation.IContent> _contentQueue;

		// Token: 0x04002026 RID: 8230
		[Token(Token = "0x4002026")]
		[FieldOffset(Offset = "0x14")]
		private Tween _delayedCall;

		// Token: 0x02000988 RID: 2440
		[Token(Token = "0x2000988")]
		private class EmptyContent : CombatAnimation.IContent, IDisposable
		{
			// Token: 0x17000B68 RID: 2920
			// (get) Token: 0x06003A41 RID: 14913 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000B68")]
			public Transform Transform
			{
				[Token(Token = "0x6003A41")]
				[Address(RVA = "0x89BD", Offset = "0x89BD", VA = "0x89BD", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000B69 RID: 2921
			// (get) Token: 0x06003A42 RID: 14914 RVA: 0x0000B988 File Offset: 0x00009B88
			// (set) Token: 0x06003A43 RID: 14915 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000B69")]
			public bool IsLeft
			{
				[Token(Token = "0x6003A42")]
				[Address(RVA = "0x89BE", Offset = "0x89BE", VA = "0x89BE", Slot = "10")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6003A43")]
				[Address(RVA = "0x89BF", Offset = "0x89BF", VA = "0x89BF", Slot = "11")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1400018F RID: 399
			// (add) Token: 0x06003A44 RID: 14916 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x06003A45 RID: 14917 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1400018F")]
			public event Action<CombatAnimation.IContent> OnCompleteEvent
			{
				[Token(Token = "0x6003A44")]
				[Address(RVA = "0x89C0", Offset = "0x89C0", VA = "0x89C0", Slot = "4")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x6003A45")]
				[Address(RVA = "0x89C1", Offset = "0x89C1", VA = "0x89C1", Slot = "5")]
				[CompilerGenerated]
				remove
				{
				}
			}

			// Token: 0x06003A46 RID: 14918 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003A46")]
			[Address(RVA = "0x89C2", Offset = "0x89C2", VA = "0x89C2", Slot = "12")]
			public void Dispose()
			{
			}

			// Token: 0x06003A47 RID: 14919 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003A47")]
			[Address(RVA = "0x89C3", Offset = "0x89C3", VA = "0x89C3", Slot = "7")]
			public void Hide()
			{
			}

			// Token: 0x06003A48 RID: 14920 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003A48")]
			[Address(RVA = "0x89C4", Offset = "0x89C4", VA = "0x89C4", Slot = "8")]
			public void Play(bool loop)
			{
			}

			// Token: 0x06003A49 RID: 14921 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003A49")]
			[Address(RVA = "0x89C5", Offset = "0x89C5", VA = "0x89C5", Slot = "6")]
			public void Show()
			{
			}

			// Token: 0x06003A4A RID: 14922 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003A4A")]
			[Address(RVA = "0x89C6", Offset = "0x89C6", VA = "0x89C6")]
			public EmptyContent()
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_OnAnimExecuteEvent ---
		void Gameplay_Combat_View_Animations_ToastCombatAnimation__add_OnAnimExecuteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57e24 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CombatAnimation_IContent__TypeInfo);
		    DAT_ram_00a57e24 = '\x01';
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


		/* --- GHIDRA: set_IsPlaying ---
		void Gameplay_Combat_View_Animations_ToastCombatAnimation__set_IsPlaying
		               (int param1,float param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57e25 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_CombatAnimation_IContent___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Queue_CombatAnimation_IContent__TypeInfo);
		    DAT_ram_00a57e25 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_Queue_CombatAnimation_IContent__TypeInfo);
		  Sirenix_Serialization_StackFormatter_object____Il2CppFullySharedGenericType___SerializeImplementation
		            (param1_00,Method_System_Collections_Generic_Queue_CombatAnimation_IContent___ctor__);
		  *(undefined4 *)(param1 + 0x10) = param1_00;
		  *(float *)(param1 + 0xc) = param2;
		  return;
		}
		*/

}
