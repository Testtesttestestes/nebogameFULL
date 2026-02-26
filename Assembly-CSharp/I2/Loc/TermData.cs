using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200139C RID: 5020
	[Token(Token = "0x200139C")]
	[Serializable]
	public class TermData
	{
		// Token: 0x06007790 RID: 30608 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007790")]
		[Address(RVA = "0xC0F1", Offset = "0xC0F1", VA = "0xC0F1")]
		public string GetTranslation(int idx, [Optional] string specialization, bool editMode = false)
		{
		/* --- GHIDRA: GetTranslation ---
		void I2_Loc_TermData__GetTranslation(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  
		  if (0 < *(int *)(*(int *)(param1 + 0x14) + 0xc)) {
		    param2_00 = 0;
		    do {
		      I2_Loc_TermData__RemoveSpecialization(param1,param2_00,param2,param2_00);
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(*(int *)(param1 + 0x14) + 0xc));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06007791 RID: 30609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007791")]
		[Address(RVA = "0x361E", Offset = "0x361E", VA = "0x361E")]
		public void SetTranslation(int idx, string translation, [Optional] string specialization)
		{
		}

		// Token: 0x06007792 RID: 30610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007792")]
		[Address(RVA = "0xC0F2", Offset = "0xC0F2", VA = "0xC0F2")]
		public void RemoveSpecialization(string specialization)
		{
		/* --- GHIDRA: RemoveSpecialization ---
		uint I2_Loc_TermData__RemoveSpecialization
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  return (*(byte *)(*(int *)(param1 + 0x18) + param2 + 0x10) & 2) >> 1;
		}
		*/

		/* --- GHIDRA: RemoveSpecialization ---
		uint I2_Loc_TermData__RemoveSpecialization
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  return (*(byte *)(*(int *)(param1 + 0x18) + param2 + 0x10) & 2) >> 1;
		}
		*/

		}

		// Token: 0x06007793 RID: 30611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007793")]
		[Address(RVA = "0xC0F3", Offset = "0xC0F3", VA = "0xC0F3")]
		public void RemoveSpecialization(int idx, string specialization)
		{
		}

		// Token: 0x06007794 RID: 30612 RVA: 0x00015F18 File Offset: 0x00014118
		[Token(Token = "0x6007794")]
		[Address(RVA = "0xC0F4", Offset = "0xC0F4", VA = "0xC0F4")]
		public bool IsAutoTranslated(int idx, bool IsTouch)
		{
		/* --- GHIDRA: IsAutoTranslated ---
		void I2_Loc_TermData__IsAutoTranslated(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param2_00;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a54df8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Resize_byte___);
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Resize_string___);
		    DAT_ram_00a54df8 = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(param1 + 0x14) + 0xc);
		  iVar3 = *(int *)(*(int *)(param1 + 0x18) + 0xc);
		  param2_00 = iVar1;
		  if (iVar1 <= iVar3) {
		    param2_00 = iVar3;
		  }
		  if (iVar1 < iVar3) {
		    BestHTTP_SocketIO_Packet__EncodeBinary
		              ((int *)(param1 + 0x14),param2_00,Method_System_Array_Resize_string___);
		    iVar3 = *(int *)(*(int *)(param1 + 0x18) + 0xc);
		  }
		  if (iVar3 != param2_00) {
		    BestHTTP_SocketIO_Packet__EncodeBinary
		              ((int *)(param1 + 0x18),param2_00,Method_System_Array_Resize_byte___);
		  }
		  if (*(int *)(param1 + 0x1c) != 0) {
		    iVar1 = *(int *)(*(int *)(param1 + 0x1c) + 0xc);
		    if (param2_00 <= iVar1) {
		      iVar1 = param2_00;
		    }
		    if (0 < iVar1) {
		      iVar1 = 0;
		      do {
		        iVar2 = iVar1 * 4;
		        iVar3 = func_ii_4769(*(undefined4 *)(iVar2 + *(int *)(param1 + 0x14) + 0x10),0);
		        if ((iVar3 != 0) &&
		           (iVar3 = func_ii_4769(*(undefined4 *)(*(int *)(param1 + 0x1c) + iVar2 + 0x10),0),
		           iVar3 == 0)) {
		          *(undefined4 *)(*(int *)(param1 + 0x14) + iVar2 + 0x10) =
		               *(undefined4 *)(*(int *)(param1 + 0x1c) + iVar2 + 0x10);
		          *(undefined4 *)(*(int *)(param1 + 0x1c) + iVar2 + 0x10) = 0;
		        }
		        iVar1 = iVar1 + 1;
		        iVar3 = *(int *)(*(int *)(param1 + 0x1c) + 0xc);
		        if (param2_00 <= iVar3) {
		          iVar3 = param2_00;
		        }
		      } while (iVar1 < iVar3);
		    }
		    *(undefined4 *)(param1 + 0x1c) = 0;
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06007795 RID: 30613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007795")]
		[Address(RVA = "0xC0F5", Offset = "0xC0F5", VA = "0xC0F5")]
		public void Validate()
		{
		/* --- GHIDRA: Validate ---
		undefined4 I2_Loc_TermData__Validate(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a54dfa == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_18958);
		    DAT_ram_00a54dfa = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x14);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      iVar2 = func_ii_4769(*(undefined4 *)(iVar2 + iVar1 * 4 + 0x10),0);
		      if ((iVar2 == 0) &&
		         (iVar2 = func_ii_7903(*(undefined4 *)(*(int *)(param1 + 0x14) + iVar1 * 4 + 0x10),
		                               StringLiteral_18958,0), iVar2 != 0)) {
		        return 1;
		      }
		      iVar1 = iVar1 + 1;
		      iVar2 = *(int *)(param1 + 0x14);
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return 0;
		}
		*/

		}

		// Token: 0x06007796 RID: 30614 RVA: 0x00015F30 File Offset: 0x00014130
		[Token(Token = "0x6007796")]
		[Address(RVA = "0x35EC", Offset = "0x35EC", VA = "0x35EC")]
		public bool IsTerm(string name, bool allowCategoryMistmatch)
		{
		/* --- GHIDRA: IsTerm ---
		int * I2_Loc_TermData__IsTerm(int *param1)
		
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

			return default(bool);
		}

		// Token: 0x06007797 RID: 30615 RVA: 0x00015F48 File Offset: 0x00014148
		[Token(Token = "0x6007797")]
		[Address(RVA = "0xC0F6", Offset = "0xC0F6", VA = "0xC0F6")]
		public bool HasSpecializations()
		{
		/* --- GHIDRA: HasSpecializations ---
		void I2_Loc_TermData__HasSpecializations(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a54dfc == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Empty_byte___);
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Empty_string___);
		    DAT_ram_00a54dfc = '\x01';
		  }
		  *(undefined4 *)(param1 + 8) = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  iVar2 = Method_System_Array_Empty_string___;
		  iVar1 = *(int *)(Method_System_Array_Empty_string___ + 0x1c);
		  if (iVar1 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(Method_System_Array_Empty_string___);
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
		  *(undefined4 *)(param1 + 0x14) = **(undefined4 **)(iVar2 + 0x5c);
		  iVar2 = Method_System_Array_Empty_byte___;
		  iVar1 = *(int *)(Method_System_Array_Empty_byte___ + 0x1c);
		  if (iVar1 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(Method_System_Array_Empty_byte___);
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
		  *(undefined4 *)(param1 + 0x18) = **(undefined4 **)(iVar2 + 0x5c);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06007798 RID: 30616 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007798")]
		[Address(RVA = "0x35F2", Offset = "0x35F2", VA = "0x35F2")]
		public List<string> GetAllSpecializations()
		{
		/* --- GHIDRA: GetAllSpecializations ---
		int * I2_Loc_TermData__GetAllSpecializations(int *param1)
		
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

			return null;
		}

		// Token: 0x06007799 RID: 30617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007799")]
		[Address(RVA = "0xC0F7", Offset = "0xC0F7", VA = "0xC0F7")]
		public TermData()
		{
		}

		// Token: 0x04003E6A RID: 15978
		[Token(Token = "0x4003E6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Term;

		// Token: 0x04003E6B RID: 15979
		[Token(Token = "0x4003E6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public eTermType TermType;

		// Token: 0x04003E6C RID: 15980
		[Token(Token = "0x4003E6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[NonSerialized]
		public string Description;

		// Token: 0x04003E6D RID: 15981
		[Token(Token = "0x4003E6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public string[] Languages;

		// Token: 0x04003E6E RID: 15982
		[Token(Token = "0x4003E6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public byte[] Flags;

		// Token: 0x04003E6F RID: 15983
		[Token(Token = "0x4003E6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private string[] Languages_Touch;
	}
}
