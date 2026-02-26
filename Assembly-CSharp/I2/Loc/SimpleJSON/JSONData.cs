using System;
using System.IO;
using Il2CppDummyDll;

namespace I2.Loc.SimpleJSON
{
	// Token: 0x020013C3 RID: 5059
	[Token(Token = "0x20013C3")]
	public class JSONData : JSONNode
	{
		// Token: 0x170017D8 RID: 6104
		// (get) Token: 0x0600787E RID: 30846 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600787F RID: 30847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017D8")]
		public override string Value
		{
			[Token(Token = "0x600787E")]
			[Address(RVA = "0xC1D0", Offset = "0xC1D0", VA = "0xC1D0", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600787F")]
			[Address(RVA = "0xC1D1", Offset = "0xC1D1", VA = "0xC1D1", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x06007880 RID: 30848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007880")]
		[Address(RVA = "0xC1D2", Offset = "0xC1D2", VA = "0xC1D2")]
		public JSONData(string aData)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 I2_Loc_SimpleJSON_JSONData___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a54e75 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_527);
		    DAT_ram_00a54e75 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_object__object___Remove
		                    (*(undefined4 *)(param1 + 8),param1);
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (StringLiteral_527,uVar1,StringLiteral_527,0);
		  return uVar1;
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4 I2_Loc_SimpleJSON_JSONData___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a54e75 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_527);
		    DAT_ram_00a54e75 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_object__object___Remove
		                    (*(undefined4 *)(param1 + 8),param1);
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (StringLiteral_527,uVar1,StringLiteral_527,0);
		  return uVar1;
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4 I2_Loc_SimpleJSON_JSONData___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a54e75 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_527);
		    DAT_ram_00a54e75 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_object__object___Remove
		                    (*(undefined4 *)(param1 + 8),param1);
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (StringLiteral_527,uVar1,StringLiteral_527,0);
		  return uVar1;
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4 I2_Loc_SimpleJSON_JSONData___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a54e75 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_527);
		    DAT_ram_00a54e75 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_object__object___Remove
		                    (*(undefined4 *)(param1 + 8),param1);
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (StringLiteral_527,uVar1,StringLiteral_527,0);
		  return uVar1;
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4 I2_Loc_SimpleJSON_JSONData___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a54e75 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_527);
		    DAT_ram_00a54e75 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_object__object___Remove
		                    (*(undefined4 *)(param1 + 8),param1);
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (StringLiteral_527,uVar1,StringLiteral_527,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06007881 RID: 30849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007881")]
		[Address(RVA = "0xC1D3", Offset = "0xC1D3", VA = "0xC1D3")]
		public JSONData(float aData)
		{
		}

		// Token: 0x06007882 RID: 30850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007882")]
		[Address(RVA = "0xC1D4", Offset = "0xC1D4", VA = "0xC1D4")]
		public JSONData(double aData)
		{
		}

		// Token: 0x06007883 RID: 30851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007883")]
		[Address(RVA = "0xC1D5", Offset = "0xC1D5", VA = "0xC1D5")]
		public JSONData(bool aData)
		{
		}

		// Token: 0x06007884 RID: 30852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007884")]
		[Address(RVA = "0xC1D6", Offset = "0xC1D6", VA = "0xC1D6")]
		public JSONData(int aData)
		{
		}

		// Token: 0x06007885 RID: 30853 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007885")]
		[Address(RVA = "0xC1D7", Offset = "0xC1D7", VA = "0xC1D7", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		void I2_Loc_SimpleJSON_JSONData__ToString(int *param1,int *param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 uVar5;
		  uint uVar6;
		  
		  if (DAT_ram_00a54e77 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a54e77 = '\x01';
		  }
		  piVar2 = (int *)unnamed_function_1417(I2_Loc_SimpleJSON_JSONData_TypeInfo);
		  piVar2[2] = StringLiteral_5;
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x154));
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x150) * 4))(param1,uVar1);
		  uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),uVar3);
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x158) * 4))
		            (piVar2,uVar1,*(undefined4 *)(*piVar2 + 0x15c));
		  uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  iVar4 = System_Collections_CollectionBase___ctor(piVar2[2],param1[2],0);
		  if (iVar4 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param2 + 0x100) * 4))
		              (param2,CONCAT44(uVar3,4),*(undefined4 *)(*param2 + 0x104));
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x150) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x154));
		    (**(code **)((ulonglong)*(uint *)(*param2 + 0x140) * 4))
		              (param2,uVar3,*(undefined4 *)(*param2 + 0x144));
		    return;
		  }
		  uVar1 = CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x164));
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x160) * 4))(param1,uVar1);
		  uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),uVar3);
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x168) * 4))
		            (piVar2,uVar1,*(undefined4 *)(*piVar2 + 0x16c));
		  uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  iVar4 = System_Collections_CollectionBase___ctor(piVar2[2],param1[2],0);
		  if (iVar4 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param2 + 0x100) * 4))
		              (param2,CONCAT44(uVar3,7),*(undefined4 *)(*param2 + 0x104));
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x160) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x164));
		    (**(code **)((ulonglong)*(uint *)(*param2 + 0x160) * 4))
		              (param2,uVar3,*(undefined4 *)(*param2 + 0x164));
		    return;
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x170) * 4))
		                    (param1,CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x174)));
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x178) * 4))
		            (piVar2,uVar1,*(undefined4 *)(*piVar2 + 0x17c));
		  uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  iVar4 = System_Collections_CollectionBase___ctor(piVar2[2],param1[2],0);
		  if (iVar4 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param2 + 0x100) * 4))
		              (param2,CONCAT44(uVar3,5),*(undefined4 *)(*param2 + 0x104));
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x170) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x174));
		    (**(code **)((ulonglong)*(uint *)(*param2 + 0x128) * 4))
		              (param2,uVar1,*(undefined4 *)(*param2 + 300));
		    return;
		  }
		  uVar1 = CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x184));
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x180) * 4))(param1,uVar1);
		  uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),uVar3);
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x188) * 4))
		            (piVar2,uVar1,*(undefined4 *)(*piVar2 + 0x18c));
		  uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  iVar4 = System_Collections_CollectionBase___ctor(piVar2[2],param1[2],0);
		  uVar5 = *(undefined4 *)(*param2 + 0x104);
		  uVar6 = *(uint *)(*param2 + 0x100);
		  if (iVar4 != 0) {
		    (**(code **)((ulonglong)uVar6 * 4))(param2,CONCAT44(uVar3,6),uVar5);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x180) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x184));
		    (**(code **)((ulonglong)*(uint *)(*param2 + 0xf8) * 4))
		              (param2,uVar3,*(undefined4 *)(*param2 + 0xfc));
		    return;
		  }
		  (**(code **)((ulonglong)uVar6 * 4))(param2,CONCAT44(uVar3,3),uVar5);
		  (**(code **)((ulonglong)*(uint *)(*param2 + 0x168) * 4))
		            (param2,param1[2],*(undefined4 *)(*param2 + 0x16c));
		  return;
		}
		*/

		/* --- GHIDRA: ToString ---
		void I2_Loc_SimpleJSON_JSONData__ToString(int *param1,int *param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 uVar5;
		  uint uVar6;
		  
		  if (DAT_ram_00a54e77 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a54e77 = '\x01';
		  }
		  piVar2 = (int *)unnamed_function_1417(I2_Loc_SimpleJSON_JSONData_TypeInfo);
		  piVar2[2] = StringLiteral_5;
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x154));
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x150) * 4))(param1,uVar1);
		  uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),uVar3);
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x158) * 4))
		            (piVar2,uVar1,*(undefined4 *)(*piVar2 + 0x15c));
		  uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  iVar4 = System_Collections_CollectionBase___ctor(piVar2[2],param1[2],0);
		  if (iVar4 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param2 + 0x100) * 4))
		              (param2,CONCAT44(uVar3,4),*(undefined4 *)(*param2 + 0x104));
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x150) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x154));
		    (**(code **)((ulonglong)*(uint *)(*param2 + 0x140) * 4))
		              (param2,uVar3,*(undefined4 *)(*param2 + 0x144));
		    return;
		  }
		  uVar1 = CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x164));
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x160) * 4))(param1,uVar1);
		  uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),uVar3);
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x168) * 4))
		            (piVar2,uVar1,*(undefined4 *)(*piVar2 + 0x16c));
		  uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  iVar4 = System_Collections_CollectionBase___ctor(piVar2[2],param1[2],0);
		  if (iVar4 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param2 + 0x100) * 4))
		              (param2,CONCAT44(uVar3,7),*(undefined4 *)(*param2 + 0x104));
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x160) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x164));
		    (**(code **)((ulonglong)*(uint *)(*param2 + 0x160) * 4))
		              (param2,uVar3,*(undefined4 *)(*param2 + 0x164));
		    return;
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x170) * 4))
		                    (param1,CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x174)));
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x178) * 4))
		            (piVar2,uVar1,*(undefined4 *)(*piVar2 + 0x17c));
		  uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  iVar4 = System_Collections_CollectionBase___ctor(piVar2[2],param1[2],0);
		  if (iVar4 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param2 + 0x100) * 4))
		              (param2,CONCAT44(uVar3,5),*(undefined4 *)(*param2 + 0x104));
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x170) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x174));
		    (**(code **)((ulonglong)*(uint *)(*param2 + 0x128) * 4))
		              (param2,uVar1,*(undefined4 *)(*param2 + 300));
		    return;
		  }
		  uVar1 = CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x184));
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x180) * 4))(param1,uVar1);
		  uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),uVar3);
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x188) * 4))
		            (piVar2,uVar1,*(undefined4 *)(*piVar2 + 0x18c));
		  uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  iVar4 = System_Collections_CollectionBase___ctor(piVar2[2],param1[2],0);
		  uVar5 = *(undefined4 *)(*param2 + 0x104);
		  uVar6 = *(uint *)(*param2 + 0x100);
		  if (iVar4 != 0) {
		    (**(code **)((ulonglong)uVar6 * 4))(param2,CONCAT44(uVar3,6),uVar5);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x180) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x184));
		    (**(code **)((ulonglong)*(uint *)(*param2 + 0xf8) * 4))
		              (param2,uVar3,*(undefined4 *)(*param2 + 0xfc));
		    return;
		  }
		  (**(code **)((ulonglong)uVar6 * 4))(param2,CONCAT44(uVar3,3),uVar5);
		  (**(code **)((ulonglong)*(uint *)(*param2 + 0x168) * 4))
		            (param2,param1[2],*(undefined4 *)(*param2 + 0x16c));
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06007886 RID: 30854 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007886")]
		[Address(RVA = "0xC1D8", Offset = "0xC1D8", VA = "0xC1D8", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		// Token: 0x06007887 RID: 30855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007887")]
		[Address(RVA = "0xC1D9", Offset = "0xC1D9", VA = "0xC1D9", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		// Token: 0x04003F0D RID: 16141
		[Token(Token = "0x4003F0D")]
		[FieldOffset(Offset = "0x8")]
		private string m_Data;
	}
}
