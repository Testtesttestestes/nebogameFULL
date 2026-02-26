using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Core;
using Il2CppDummyDll;

namespace Gameplay.Competition.Model
{
	// Token: 0x020008F5 RID: 2293
	[Token(Token = "0x20008F5")]
	public class OwnerRating
	{
		// Token: 0x14000173 RID: 371
		// (add) Token: 0x06003602 RID: 13826 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003603 RID: 13827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000173")]
		public event ChangedFromTo<OwnerRating> ChangedEvent
		{
			[Token(Token = "0x6003602")]
			[Address(RVA = "0x860F", Offset = "0x860F", VA = "0x860F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003603")]
			[Address(RVA = "0x8610", Offset = "0x8610", VA = "0x8610")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06003604 RID: 13828 RVA: 0x0000AEC0 File Offset: 0x000090C0
		// (set) Token: 0x06003605 RID: 13829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ABA")]
		public int Place
		{
			[Token(Token = "0x6003604")]
			[Address(RVA = "0x8611", Offset = "0x8611", VA = "0x8611")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003605")]
			[Address(RVA = "0x8612", Offset = "0x8612", VA = "0x8612")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06003606 RID: 13830 RVA: 0x0000AED8 File Offset: 0x000090D8
		// (set) Token: 0x06003607 RID: 13831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ABB")]
		public ulong Value
		{
			[Token(Token = "0x6003606")]
			[Address(RVA = "0x8613", Offset = "0x8613", VA = "0x8613")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6003607")]
			[Address(RVA = "0x8614", Offset = "0x8614", VA = "0x8614")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003608 RID: 13832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003608")]
		[Address(RVA = "0x8615", Offset = "0x8615", VA = "0x8615")]
		public void SetPlace(int value)
		{
		/* --- GHIDRA: SetPlace ---
		void Gameplay_Competition_Model_OwnerRating__SetPlace(int param1,longlong param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a63abd == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Model_OwnerRating_TypeInfo);
		    DAT_ram_00a63abd = '\x01';
		  }
		  if (*(longlong *)(param1 + 0x10) != param2) {
		    param1_00 = (int *)unnamed_function_1419(param1);
		    if (param1_00 != (int *)0x0) {
		      if (((uint)*(byte *)(*param1_00 + 0xb8) <
		           (uint)*(byte *)(Gameplay_Competition_Model_OwnerRating_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*param1_00 + 100) +
		                   (uint)*(byte *)(Gameplay_Competition_Model_OwnerRating_TypeInfo + 0xb8) * 4 + -4)
		          != Gameplay_Competition_Model_OwnerRating_TypeInfo)) {
		        System_Activator__CreateInstance(param1_00,Gameplay_Competition_Model_OwnerRating_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    *(longlong *)(param1 + 0x10) = param2;
		    iVar1 = *(int *)(param1 + 8);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_00,param1,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003609 RID: 13833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003609")]
		[Address(RVA = "0x8616", Offset = "0x8616", VA = "0x8616")]
		public void SetValue(ulong value)
		{
		/* --- GHIDRA: SetValue ---
		void Gameplay_Competition_Model_OwnerRating__SetValue
		               (int param1,longlong param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  undefined4 param1_01;
		  int iVar1;
		  
		  if (DAT_ram_00a63abe == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Model_OwnerRating_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_ObjectModel_ReadOnlyCollection_ulong___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_ObjectModel_ReadOnlyCollection_ulong__TypeInfo)
		    ;
		    DAT_ram_00a63abe = '\x01';
		  }
		  if (*(longlong *)(param1 + 0x10) != param2) {
		    param1_00 = (int *)unnamed_function_1419(param1);
		    if (param1_00 != (int *)0x0) {
		      if (((uint)*(byte *)(*param1_00 + 0xb8) <
		           (uint)*(byte *)(Gameplay_Competition_Model_OwnerRating_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*param1_00 + 100) +
		                   (uint)*(byte *)(Gameplay_Competition_Model_OwnerRating_TypeInfo + 0xb8) * 4 + -4)
		          != Gameplay_Competition_Model_OwnerRating_TypeInfo)) {
		        System_Activator__CreateInstance(param1_00,Gameplay_Competition_Model_OwnerRating_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    param1_01 = unnamed_function_1417
		                          (System_Collections_ObjectModel_ReadOnlyCollection_ulong__TypeInfo);
		    System_Runtime_CompilerServices_ReadOnlyCollectionBuilder___Il2CppFullySharedGenericType___set_Item
		              (param1_01,param3,
		               Method_System_Collections_ObjectModel_ReadOnlyCollection_ulong___ctor__);
		    *(longlong *)(param1 + 0x10) = param2;
		    *(undefined4 *)(param1 + 0x18) = param1_01;
		    iVar1 = *(int *)(param1 + 8);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_00,param1,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600360A RID: 13834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600360A")]
		[Address(RVA = "0x8617", Offset = "0x8617", VA = "0x8617")]
		public void SetValueWhitHistory(ulong value, IList<ulong> history)
		{
		/* --- GHIDRA: SetValueWhitHistory ---
		void Gameplay_Competition_Model_OwnerRating__SetValueWhitHistory
		               (int param1,int param2,longlong param3,undefined4 param4)
		
		{
		  bool bVar1;
		  int *param1_00;
		  int iVar2;
		  
		  bVar1 = false;
		  if (DAT_ram_00a63abf == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Model_OwnerRating_TypeInfo);
		    DAT_ram_00a63abf = '\x01';
		  }
		  if (param2 == *(int *)(param1 + 0xc)) {
		    bVar1 = *(longlong *)(param1 + 0x10) == param3;
		  }
		  param1_00 = (int *)unnamed_function_1419(param1);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Competition_Model_OwnerRating_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(Gameplay_Competition_Model_OwnerRating_TypeInfo + 0xb8) * 4 + -4)
		        != Gameplay_Competition_Model_OwnerRating_TypeInfo)) {
		      System_Activator__CreateInstance(param1_00,Gameplay_Competition_Model_OwnerRating_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  *(longlong *)(param1 + 0x10) = param3;
		  *(int *)(param1 + 0xc) = param2;
		  if ((!bVar1) && (iVar2 = *(int *)(param1 + 8), iVar2 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1_00,param1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600360B RID: 13835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600360B")]
		[Address(RVA = "0x8618", Offset = "0x8618", VA = "0x8618")]
		public void Fill(int place, ulong value)
		{
		/* --- GHIDRA: Fill ---
		void Gameplay_Competition_Model_OwnerRating__Fill(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a63ac0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Empty_ulong___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_ObjectModel_ReadOnlyCollection_ulong___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_ObjectModel_ReadOnlyCollection_ulong__TypeInfo)
		    ;
		    DAT_ram_00a63ac0 = '\x01';
		  }
		  iVar2 = Method_System_Array_Empty_ulong___;
		  iVar1 = *(int *)(Method_System_Array_Empty_ulong___ + 0x1c);
		  if (iVar1 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(Method_System_Array_Empty_ulong___);
		    iVar1 = *(int *)(iVar2 + 0x1c);
		  }
		  iVar1 = *(int *)(iVar1 + 8);
		  if ((*(byte *)(iVar1 + 0xbd) & 1) == 0) {
		    iVar1 = func_ii_1079(iVar1);
		  }
		  if (*(int *)(iVar1 + 0x74) == 0) {
		    func_ii_306000(iVar1);
		  }
		  iVar2 = *(int *)(*(int *)(iVar2 + 0x1c) + 8);
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  param2_00 = **(undefined4 **)(iVar2 + 0x5c);
		  param1_00 = unnamed_function_1417
		                        (System_Collections_ObjectModel_ReadOnlyCollection_ulong__TypeInfo);
		  System_Runtime_CompilerServices_ReadOnlyCollectionBuilder___Il2CppFullySharedGenericType___set_Item
		            (param1_00,param2_00,
		             Method_System_Collections_ObjectModel_ReadOnlyCollection_ulong___ctor__);
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x0600360C RID: 13836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600360C")]
		[Address(RVA = "0x8619", Offset = "0x8619", VA = "0x8619")]
		public OwnerRating()
		{
		}

		// Token: 0x04001DAE RID: 7598
		[Token(Token = "0x4001DAE")]
		[FieldOffset(Offset = "0x18")]
		public ReadOnlyCollection<ulong> ValueHistory;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ChangedEvent ---
		void Gameplay_Competition_Model_OwnerRating__add_ChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63abb == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_ChangedFromTo_OwnerRating__TypeInfo);
		    DAT_ram_00a63abb = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = Core_ChangedFromTo_OwnerRating__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,Core_ChangedFromTo_OwnerRating__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: set_Value ---
		void Gameplay_Competition_Model_OwnerRating__set_Value(int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a63abc == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Model_OwnerRating_TypeInfo);
		    DAT_ram_00a63abc = '\x01';
		  }
		  if (*(int *)(param1 + 0xc) != param2) {
		    param1_00 = (int *)unnamed_function_1419(param1);
		    if (param1_00 != (int *)0x0) {
		      if (((uint)*(byte *)(*param1_00 + 0xb8) <
		           (uint)*(byte *)(Gameplay_Competition_Model_OwnerRating_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*param1_00 + 100) +
		                   (uint)*(byte *)(Gameplay_Competition_Model_OwnerRating_TypeInfo + 0xb8) * 4 + -4)
		          != Gameplay_Competition_Model_OwnerRating_TypeInfo)) {
		        System_Activator__CreateInstance(param1_00,Gameplay_Competition_Model_OwnerRating_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    *(int *)(param1 + 0xc) = param2;
		    iVar1 = *(int *)(param1 + 8);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_00,param1,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

}
