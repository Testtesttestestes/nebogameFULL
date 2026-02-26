using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Gameplay.Combat.View.Animations
{
	// Token: 0x02000981 RID: 2433
	[Token(Token = "0x2000981")]
	public class CombatAnimationCounter
	{
		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x06003A00 RID: 14848 RVA: 0x0000B928 File Offset: 0x00009B28
		// (set) Token: 0x06003A01 RID: 14849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B62")]
		public int Value
		{
			[Token(Token = "0x6003A00")]
			[Address(RVA = "0x8984", Offset = "0x8984", VA = "0x8984")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003A01")]
			[Address(RVA = "0x8985", Offset = "0x8985", VA = "0x8985")]
			set
			{
			}
		}

		// Token: 0x06003A02 RID: 14850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A02")]
		[Address(RVA = "0x8986", Offset = "0x8986", VA = "0x8986")]
		private void HandleCountChanged()
		{
		/* --- GHIDRA: HandleCountChanged ---
		void Gameplay_Combat_View_Animations_CombatAnimationCounter__HandleCountChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a57e10 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a57e10 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0xc,param1_01,param1_00);
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

		// Token: 0x14000189 RID: 393
		// (add) Token: 0x06003A03 RID: 14851 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003A04 RID: 14852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000189")]
		private event Action _completeEvent
		{
			[Token(Token = "0x6003A03")]
			[Address(RVA = "0x8987", Offset = "0x8987", VA = "0x8987")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003A04")]
			[Address(RVA = "0x8988", Offset = "0x8988", VA = "0x8988")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400018A RID: 394
		// (add) Token: 0x06003A05 RID: 14853 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003A06 RID: 14854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400018A")]
		public event Action CompleteEvent
		{
			[Token(Token = "0x6003A05")]
			[Address(RVA = "0x8989", Offset = "0x8989", VA = "0x8989")]
			add
			{
			}
			[Token(Token = "0x6003A06")]
			[Address(RVA = "0x898A", Offset = "0x898A", VA = "0x898A")]
			remove
			{
			}
		}

		// Token: 0x06003A07 RID: 14855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A07")]
		[Address(RVA = "0x898B", Offset = "0x898B", VA = "0x898B")]
		public void Reset()
		{
		}

		// Token: 0x06003A08 RID: 14856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A08")]
		[Address(RVA = "0x898C", Offset = "0x898C", VA = "0x898C")]
		public CombatAnimationCounter()
		{
		}

		// Token: 0x04002010 RID: 8208
		[Token(Token = "0x4002010")]
		[FieldOffset(Offset = "0x8")]
		private int _value;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Value ---
		void Gameplay_Combat_View_Animations_CombatAnimationCounter__get_Value
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (((*(int *)(param1 + 8) != param2) && (*(int *)(param1 + 8) = param2, param2 == 0)) &&
		     (iVar1 = *(int *)(param1 + 0xc), iVar1 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Value ---
		void Gameplay_Combat_View_Animations_CombatAnimationCounter__set_Value(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if ((*(int *)(param1 + 8) == 0) && (iVar1 = *(int *)(param1 + 0xc), iVar1 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: add__completeEvent ---
		void Gameplay_Combat_View_Animations_CombatAnimationCounter__add__completeEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a57e11 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a57e11 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0xc,param1_01,param1_00);
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


		/* --- GHIDRA: remove__completeEvent ---
		void Gameplay_Combat_View_Animations_CombatAnimationCounter__remove__completeEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int iVar3;
		  int *piVar4;
		  
		  if (DAT_ram_00a57e12 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Contains_Delegate___);
		    DAT_ram_00a57e12 = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0xc);
		  if (piVar4 != (int *)0x0) {
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x108) * 4))
		                          (piVar4,*(undefined4 *)(*piVar4 + 0x10c));
		    iVar2 = System_Uri__get_Scheme
		                      (param1_00,param2,Method_System_Linq_Enumerable_Contains_Delegate___);
		    if (iVar2 != 0) {
		      return;
		    }
		  }
		  if (DAT_ram_00a57e10 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a57e10 = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0xc);
		  while ((piVar4 = (int *)UnityEngine_UI_Image__set_sprite(iVar2,param2,0), piVar4 == (int *)0x0 ||
		         (System_Action_TypeInfo == *piVar4))) {
		    iVar3 = func_ii_4329((int *)(param1 + 0xc),piVar4,iVar2);
		    bVar1 = iVar3 == iVar2;
		    iVar2 = iVar3;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(piVar4,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_CompleteEvent ---
		void Gameplay_Combat_View_Animations_CombatAnimationCounter__add_CompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int iVar3;
		  int *piVar4;
		  
		  if (DAT_ram_00a57e13 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Contains_Delegate___);
		    DAT_ram_00a57e13 = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0xc);
		  if (piVar4 != (int *)0x0) {
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x108) * 4))
		                          (piVar4,*(undefined4 *)(*piVar4 + 0x10c));
		    iVar2 = System_Uri__get_Scheme
		                      (param1_00,param2,Method_System_Linq_Enumerable_Contains_Delegate___);
		    if (iVar2 != 0) {
		      if (DAT_ram_00a57e11 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		        DAT_ram_00a57e11 = '\x01';
		      }
		      iVar2 = *(int *)(param1 + 0xc);
		      do {
		        piVar4 = (int *)func_ii_7048(iVar2,param2,0);
		        if ((piVar4 != (int *)0x0) && (System_Action_TypeInfo != *piVar4)) {
		          System_Activator__CreateInstance(piVar4,System_Action_TypeInfo);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar3 = func_ii_4329((int *)(param1 + 0xc),piVar4,iVar2);
		        bVar1 = iVar3 != iVar2;
		        iVar2 = iVar3;
		      } while (bVar1);
		    }
		  }
		  return;
		}
		*/

}
