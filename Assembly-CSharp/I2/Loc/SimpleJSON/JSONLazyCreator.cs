using System;
using Il2CppDummyDll;

namespace I2.Loc.SimpleJSON
{
	// Token: 0x020013C4 RID: 5060
	[Token(Token = "0x20013C4")]
	internal class JSONLazyCreator : JSONNode
	{
		// Token: 0x06007888 RID: 30856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007888")]
		[Address(RVA = "0xC1DA", Offset = "0xC1DA", VA = "0xC1DA")]
		public JSONLazyCreator(JSONNode aNode)
		{
		/* --- GHIDRA: .ctor ---
		void I2_Loc_SimpleJSON_JSONLazyCreator___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  
		  piVar1 = *(int **)(param1 + 8);
		  iVar2 = *piVar1;
		  if (*(int *)(param1 + 0xc) == 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x120) * 4))
		              (piVar1,param2,*(undefined4 *)(iVar2 + 0x124));
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe0) * 4))
		              (piVar1,*(int *)(param1 + 0xc),param2,*(undefined4 *)(iVar2 + 0xe4));
		  }
		  *(undefined4 *)(param1 + 8) = 0;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void I2_Loc_SimpleJSON_JSONLazyCreator___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  
		  piVar1 = *(int **)(param1 + 8);
		  iVar2 = *piVar1;
		  if (*(int *)(param1 + 0xc) == 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x120) * 4))
		              (piVar1,param2,*(undefined4 *)(iVar2 + 0x124));
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe0) * 4))
		              (piVar1,*(int *)(param1 + 0xc),param2,*(undefined4 *)(iVar2 + 0xe4));
		  }
		  *(undefined4 *)(param1 + 8) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06007889 RID: 30857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007889")]
		[Address(RVA = "0xC1DB", Offset = "0xC1DB", VA = "0xC1DB")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		// Token: 0x0600788A RID: 30858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600788A")]
		[Address(RVA = "0xC1DC", Offset = "0xC1DC", VA = "0xC1DC")]
		private void Set(JSONNode aVal)
		{
		/* --- GHIDRA: Set ---
		int I2_Loc_SimpleJSON_JSONLazyCreator__Set(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a54e78 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONLazyCreator_TypeInfo);
		    DAT_ram_00a54e78 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(I2_Loc_SimpleJSON_JSONLazyCreator_TypeInfo);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(undefined4 *)(iVar1 + 8) = param1;
		  return iVar1;
		}
		*/

		}

		// Token: 0x170017D9 RID: 6105
		[Token(Token = "0x170017D9")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x600788B")]
			[Address(RVA = "0xC1DD", Offset = "0xC1DD", VA = "0xC1DD", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600788C")]
			[Address(RVA = "0xC1DE", Offset = "0xC1DE", VA = "0xC1DE", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x170017DA RID: 6106
		[Token(Token = "0x170017DA")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x600788D")]
			[Address(RVA = "0xC1DF", Offset = "0xC1DF", VA = "0xC1DF", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600788E")]
			[Address(RVA = "0xC1E0", Offset = "0xC1E0", VA = "0xC1E0", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x0600788F RID: 30863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600788F")]
		[Address(RVA = "0xC1E1", Offset = "0xC1E1", VA = "0xC1E1", Slot = "12")]
		public override void Add(JSONNode aItem)
		{
		/* --- GHIDRA: Add ---
		void I2_Loc_SimpleJSON_JSONLazyCreator__Add
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int *piVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a54e7d == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONClass_TypeInfo);
		    DAT_ram_00a54e7d = '\x01';
		  }
		  param1_00 = (int *)unnamed_function_1417(I2_Loc_SimpleJSON_JSONClass_TypeInfo);
		  I2_Loc_SimpleJSON_JSONClass__Serialize(param1_00,param1);
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xe0) * 4))
		            (param1_00,param2,param3,*(undefined4 *)(*param1_00 + 0xe4));
		  piVar1 = *(int **)(param1 + 8);
		  iVar2 = *piVar1;
		  if (*(int *)(param1 + 0xc) == 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x120) * 4))
		              (piVar1,param1_00,*(undefined4 *)(iVar2 + 0x124));
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe0) * 4))
		              (piVar1,*(int *)(param1 + 0xc),param1_00,*(undefined4 *)(iVar2 + 0xe4));
		  }
		  *(undefined4 *)(param1 + 8) = 0;
		  return;
		}
		*/

		/* --- GHIDRA: Add ---
		void I2_Loc_SimpleJSON_JSONLazyCreator__Add
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int *piVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a54e7d == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONClass_TypeInfo);
		    DAT_ram_00a54e7d = '\x01';
		  }
		  param1_00 = (int *)unnamed_function_1417(I2_Loc_SimpleJSON_JSONClass_TypeInfo);
		  I2_Loc_SimpleJSON_JSONClass__Serialize(param1_00,param1);
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xe0) * 4))
		            (param1_00,param2,param3,*(undefined4 *)(*param1_00 + 0xe4));
		  piVar1 = *(int **)(param1 + 8);
		  iVar2 = *piVar1;
		  if (*(int *)(param1 + 0xc) == 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x120) * 4))
		              (piVar1,param1_00,*(undefined4 *)(iVar2 + 0x124));
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe0) * 4))
		              (piVar1,*(int *)(param1 + 0xc),param1_00,*(undefined4 *)(iVar2 + 0xe4));
		  }
		  *(undefined4 *)(param1 + 8) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06007890 RID: 30864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007890")]
		[Address(RVA = "0xC1E2", Offset = "0xC1E2", VA = "0xC1E2", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		// Token: 0x06007891 RID: 30865 RVA: 0x00016248 File Offset: 0x00014448
		[Token(Token = "0x6007891")]
		[Address(RVA = "0xC1E3", Offset = "0xC1E3", VA = "0xC1E3")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		// Token: 0x06007892 RID: 30866 RVA: 0x00016260 File Offset: 0x00014460
		[Token(Token = "0x6007892")]
		[Address(RVA = "0xC1E4", Offset = "0xC1E4", VA = "0xC1E4")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		// Token: 0x06007893 RID: 30867 RVA: 0x00016278 File Offset: 0x00014478
		[Token(Token = "0x6007893")]
		[Address(RVA = "0xC1E5", Offset = "0xC1E5", VA = "0xC1E5", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06007894 RID: 30868 RVA: 0x00016290 File Offset: 0x00014490
		[Token(Token = "0x6007894")]
		[Address(RVA = "0xC1E6", Offset = "0xC1E6", VA = "0xC1E6", Slot = "2")]
		public override int GetHashCode()
		{
		/* --- GHIDRA: GetHashCode ---
		undefined4 I2_Loc_SimpleJSON_JSONLazyCreator__GetHashCode(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a54e7e == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a54e7e = '\x01';
		  }
		  return StringLiteral_5;
		}
		*/

			return 0;
		}

		// Token: 0x06007895 RID: 30869 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007895")]
		[Address(RVA = "0xC1E7", Offset = "0xC1E7", VA = "0xC1E7", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		undefined4 I2_Loc_SimpleJSON_JSONLazyCreator__ToString(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a54e80 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONData_TypeInfo);
		    DAT_ram_00a54e80 = '\x01';
		  }
		  piVar1 = (int *)unnamed_function_1417(I2_Loc_SimpleJSON_JSONData_TypeInfo);
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x158) * 4))
		            (piVar1,0,*(undefined4 *)(*piVar1 + 0x15c));
		  piVar2 = *(int **)(param1 + 8);
		  iVar3 = *piVar2;
		  if (*(int *)(param1 + 0xc) == 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x120) * 4))
		              (piVar2,piVar1,*(undefined4 *)(iVar3 + 0x124));
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe0) * 4))
		              (piVar2,*(int *)(param1 + 0xc),piVar1,*(undefined4 *)(iVar3 + 0xe4));
		  }
		  *(undefined4 *)(param1 + 8) = 0;
		  return 0;
		}
		*/

		/* --- GHIDRA: ToString ---
		undefined4 I2_Loc_SimpleJSON_JSONLazyCreator__ToString(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a54e80 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONData_TypeInfo);
		    DAT_ram_00a54e80 = '\x01';
		  }
		  piVar1 = (int *)unnamed_function_1417(I2_Loc_SimpleJSON_JSONData_TypeInfo);
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x158) * 4))
		            (piVar1,0,*(undefined4 *)(*piVar1 + 0x15c));
		  piVar2 = *(int **)(param1 + 8);
		  iVar3 = *piVar2;
		  if (*(int *)(param1 + 0xc) == 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x120) * 4))
		              (piVar2,piVar1,*(undefined4 *)(iVar3 + 0x124));
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe0) * 4))
		              (piVar2,*(int *)(param1 + 0xc),piVar1,*(undefined4 *)(iVar3 + 0xe4));
		  }
		  *(undefined4 *)(param1 + 8) = 0;
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06007896 RID: 30870 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007896")]
		[Address(RVA = "0xC1E8", Offset = "0xC1E8", VA = "0xC1E8", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		// Token: 0x170017DB RID: 6107
		// (get) Token: 0x06007897 RID: 30871 RVA: 0x000162A8 File Offset: 0x000144A8
		// (set) Token: 0x06007898 RID: 30872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017DB")]
		public override int AsInt
		{
			[Token(Token = "0x6007897")]
			[Address(RVA = "0xC1E9", Offset = "0xC1E9", VA = "0xC1E9", Slot = "18")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6007898")]
			[Address(RVA = "0xC1EA", Offset = "0xC1EA", VA = "0xC1EA", Slot = "19")]
			set
			{
			}
		}

		// Token: 0x170017DC RID: 6108
		// (get) Token: 0x06007899 RID: 30873 RVA: 0x000162C0 File Offset: 0x000144C0
		// (set) Token: 0x0600789A RID: 30874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017DC")]
		public override float AsFloat
		{
			[Token(Token = "0x6007899")]
			[Address(RVA = "0xC1EB", Offset = "0xC1EB", VA = "0xC1EB", Slot = "20")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600789A")]
			[Address(RVA = "0xC1EC", Offset = "0xC1EC", VA = "0xC1EC", Slot = "21")]
			set
			{
			}
		}

		// Token: 0x170017DD RID: 6109
		// (get) Token: 0x0600789B RID: 30875 RVA: 0x000162D8 File Offset: 0x000144D8
		// (set) Token: 0x0600789C RID: 30876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017DD")]
		public override double AsDouble
		{
			[Token(Token = "0x600789B")]
			[Address(RVA = "0xC1ED", Offset = "0xC1ED", VA = "0xC1ED", Slot = "22")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x600789C")]
			[Address(RVA = "0xC1EE", Offset = "0xC1EE", VA = "0xC1EE", Slot = "23")]
			set
			{
			}
		}

		// Token: 0x170017DE RID: 6110
		// (get) Token: 0x0600789D RID: 30877 RVA: 0x000162F0 File Offset: 0x000144F0
		// (set) Token: 0x0600789E RID: 30878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017DE")]
		public override bool AsBool
		{
			[Token(Token = "0x600789D")]
			[Address(RVA = "0xC1EF", Offset = "0xC1EF", VA = "0xC1EF", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600789E")]
			[Address(RVA = "0xC1F0", Offset = "0xC1F0", VA = "0xC1F0", Slot = "25")]
			set
			{
			}
		}

		// Token: 0x170017DF RID: 6111
		// (get) Token: 0x0600789F RID: 30879 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017DF")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x600789F")]
			[Address(RVA = "0xC1F1", Offset = "0xC1F1", VA = "0xC1F1", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x170017E0 RID: 6112
		// (get) Token: 0x060078A0 RID: 30880 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017E0")]
		public override JSONClass AsObject
		{
			[Token(Token = "0x60078A0")]
			[Address(RVA = "0xC1F2", Offset = "0xC1F2", VA = "0xC1F2", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x04003F0E RID: 16142
		[Token(Token = "0x4003F0E")]
		[FieldOffset(Offset = "0x8")]
		private JSONNode m_Node;

		// Token: 0x04003F0F RID: 16143
		[Token(Token = "0x4003F0F")]
		[FieldOffset(Offset = "0xC")]
		private string m_Key;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Item ---
		void I2_Loc_SimpleJSON_JSONLazyCreator__get_Item
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int *piVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a54e7b == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONClass_TypeInfo);
		    DAT_ram_00a54e7b = '\x01';
		  }
		  param1_00 = (int *)unnamed_function_1417(I2_Loc_SimpleJSON_JSONClass_TypeInfo);
		  I2_Loc_SimpleJSON_JSONClass__Serialize(param1_00,param1);
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xe0) * 4))
		            (param1_00,param2,param3,*(undefined4 *)(*param1_00 + 0xe4));
		  piVar1 = *(int **)(param1 + 8);
		  iVar2 = *piVar1;
		  if (*(int *)(param1 + 0xc) == 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x120) * 4))
		              (piVar1,param1_00,*(undefined4 *)(iVar2 + 0x124));
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe0) * 4))
		              (piVar1,*(int *)(param1 + 0xc),param1_00,*(undefined4 *)(iVar2 + 0xe4));
		  }
		  *(undefined4 *)(param1 + 8) = 0;
		  return;
		}
		*/


		/* --- GHIDRA: set_Item ---
		void I2_Loc_SimpleJSON_JSONLazyCreator__set_Item(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  int *piVar3;
		  
		  if (DAT_ram_00a54e7c == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONArray_TypeInfo);
		    DAT_ram_00a54e7c = '\x01';
		  }
		  piVar1 = (int *)unnamed_function_1417(I2_Loc_SimpleJSON_JSONArray_TypeInfo);
		  if (DAT_ram_00a54e5a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_JSONNode___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_JSONNode__TypeInfo);
		    DAT_ram_00a54e5a = '\x01';
		  }
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_JSONNode__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,Method_System_Collections_Generic_List_JSONNode___ctor__);
		  piVar1[2] = iVar2;
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x120) * 4))
		            (piVar1,param2,*(undefined4 *)(*piVar1 + 0x124));
		  piVar3 = *(int **)(param1 + 8);
		  iVar2 = *piVar3;
		  if (*(int *)(param1 + 0xc) == 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x120) * 4))
		              (piVar3,piVar1,*(undefined4 *)(iVar2 + 0x124));
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe0) * 4))
		              (piVar3,*(int *)(param1 + 0xc),piVar1,*(undefined4 *)(iVar2 + 0xe4));
		  }
		  *(undefined4 *)(param1 + 8) = 0;
		  return;
		}
		*/


		/* --- GHIDRA: get_Item ---
		void I2_Loc_SimpleJSON_JSONLazyCreator__get_Item
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int *piVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a54e7b == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONClass_TypeInfo);
		    DAT_ram_00a54e7b = '\x01';
		  }
		  param1_00 = (int *)unnamed_function_1417(I2_Loc_SimpleJSON_JSONClass_TypeInfo);
		  I2_Loc_SimpleJSON_JSONClass__Serialize(param1_00,param1);
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xe0) * 4))
		            (param1_00,param2,param3,*(undefined4 *)(*param1_00 + 0xe4));
		  piVar1 = *(int **)(param1 + 8);
		  iVar2 = *piVar1;
		  if (*(int *)(param1 + 0xc) == 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x120) * 4))
		              (piVar1,param1_00,*(undefined4 *)(iVar2 + 0x124));
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe0) * 4))
		              (piVar1,*(int *)(param1 + 0xc),param1_00,*(undefined4 *)(iVar2 + 0xe4));
		  }
		  *(undefined4 *)(param1 + 8) = 0;
		  return;
		}
		*/


		/* --- GHIDRA: set_Item ---
		void I2_Loc_SimpleJSON_JSONLazyCreator__set_Item(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  int *piVar3;
		  
		  if (DAT_ram_00a54e7c == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONArray_TypeInfo);
		    DAT_ram_00a54e7c = '\x01';
		  }
		  piVar1 = (int *)unnamed_function_1417(I2_Loc_SimpleJSON_JSONArray_TypeInfo);
		  if (DAT_ram_00a54e5a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_JSONNode___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_JSONNode__TypeInfo);
		    DAT_ram_00a54e5a = '\x01';
		  }
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_JSONNode__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,Method_System_Collections_Generic_List_JSONNode___ctor__);
		  piVar1[2] = iVar2;
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x120) * 4))
		            (piVar1,param2,*(undefined4 *)(*piVar1 + 0x124));
		  piVar3 = *(int **)(param1 + 8);
		  iVar2 = *piVar3;
		  if (*(int *)(param1 + 0xc) == 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x120) * 4))
		              (piVar3,piVar1,*(undefined4 *)(iVar2 + 0x124));
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe0) * 4))
		              (piVar3,*(int *)(param1 + 0xc),piVar1,*(undefined4 *)(iVar2 + 0xe4));
		  }
		  *(undefined4 *)(param1 + 8) = 0;
		  return;
		}
		*/


		/* --- GHIDRA: op_Equality ---
		uint I2_Loc_SimpleJSON_JSONLazyCreator__op_Equality(int param1,int param2,undefined4 param3)
		
		{
		  return (uint)(param2 != 0 && param1 != param2);
		}
		*/


		/* --- GHIDRA: op_Inequality ---
		uint I2_Loc_SimpleJSON_JSONLazyCreator__op_Inequality(int param1,int param2,undefined4 param3)
		
		{
		  return (uint)(param2 == 0 || param1 == param2);
		}
		*/


		/* --- GHIDRA: get_AsInt ---
		void I2_Loc_SimpleJSON_JSONLazyCreator__get_AsInt(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a54e81 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONData_TypeInfo);
		    DAT_ram_00a54e81 = '\x01';
		  }
		  piVar1 = (int *)unnamed_function_1417(I2_Loc_SimpleJSON_JSONData_TypeInfo);
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x158) * 4))
		            (piVar1,param2,*(undefined4 *)(*piVar1 + 0x15c));
		  piVar2 = *(int **)(param1 + 8);
		  iVar3 = *piVar2;
		  if (*(int *)(param1 + 0xc) == 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x120) * 4))
		              (piVar2,piVar1,*(undefined4 *)(iVar3 + 0x124));
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe0) * 4))
		              (piVar2,*(int *)(param1 + 0xc),piVar1,*(undefined4 *)(iVar3 + 0xe4));
		  }
		  *(undefined4 *)(param1 + 8) = 0;
		  return;
		}
		*/


		/* --- GHIDRA: set_AsInt ---
		float I2_Loc_SimpleJSON_JSONLazyCreator__set_AsInt(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a54e82 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONData_TypeInfo);
		    DAT_ram_00a54e82 = '\x01';
		  }
		  piVar1 = (int *)unnamed_function_1417(I2_Loc_SimpleJSON_JSONData_TypeInfo);
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x168) * 4))
		            (piVar1,0,*(undefined4 *)(*piVar1 + 0x16c));
		  piVar2 = *(int **)(param1 + 8);
		  iVar3 = *piVar2;
		  if (*(int *)(param1 + 0xc) == 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x120) * 4))
		              (piVar2,piVar1,*(undefined4 *)(iVar3 + 0x124));
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe0) * 4))
		              (piVar2,*(int *)(param1 + 0xc),piVar1,*(undefined4 *)(iVar3 + 0xe4));
		  }
		  *(undefined4 *)(param1 + 8) = 0;
		  return 0.0;
		}
		*/


		/* --- GHIDRA: get_AsFloat ---
		void I2_Loc_SimpleJSON_JSONLazyCreator__get_AsFloat(int param1,float param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a54e83 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONData_TypeInfo);
		    DAT_ram_00a54e83 = '\x01';
		  }
		  piVar1 = (int *)unnamed_function_1417(I2_Loc_SimpleJSON_JSONData_TypeInfo);
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x168) * 4))
		            (piVar1,param2,*(undefined4 *)(*piVar1 + 0x16c));
		  piVar2 = *(int **)(param1 + 8);
		  iVar3 = *piVar2;
		  if (*(int *)(param1 + 0xc) == 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x120) * 4))
		              (piVar2,piVar1,*(undefined4 *)(iVar3 + 0x124));
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe0) * 4))
		              (piVar2,*(int *)(param1 + 0xc),piVar1,*(undefined4 *)(iVar3 + 0xe4));
		  }
		  *(undefined4 *)(param1 + 8) = 0;
		  return;
		}
		*/


		/* --- GHIDRA: set_AsFloat ---
		double I2_Loc_SimpleJSON_JSONLazyCreator__set_AsFloat(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a54e84 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONData_TypeInfo);
		    DAT_ram_00a54e84 = '\x01';
		  }
		  piVar2 = (int *)unnamed_function_1417(I2_Loc_SimpleJSON_JSONData_TypeInfo);
		  uVar1 = 0;
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x178) * 4))
		            (piVar2,0,*(undefined4 *)(*piVar2 + 0x17c));
		  piVar3 = *(int **)(param1 + 8);
		  iVar4 = *piVar3;
		  if (*(int *)(param1 + 0xc) == 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0x120) * 4))
		              (piVar3,CONCAT44(uVar1,piVar2),*(undefined4 *)(iVar4 + 0x124));
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xe0) * 4))
		              (piVar3,CONCAT44(uVar1,*(int *)(param1 + 0xc)),piVar2,*(undefined4 *)(iVar4 + 0xe4));
		  }
		  *(undefined4 *)(param1 + 8) = 0;
		  return 0.0;
		}
		*/


		/* --- GHIDRA: get_AsDouble ---
		void I2_Loc_SimpleJSON_JSONLazyCreator__get_AsDouble(int param1,double param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a54e85 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONData_TypeInfo);
		    DAT_ram_00a54e85 = '\x01';
		  }
		  piVar1 = (int *)unnamed_function_1417(I2_Loc_SimpleJSON_JSONData_TypeInfo);
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x178) * 4))
		            (piVar1,param2,*(undefined4 *)(*piVar1 + 0x17c));
		  piVar2 = *(int **)(param1 + 8);
		  iVar3 = *piVar2;
		  if (*(int *)(param1 + 0xc) == 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x120) * 4))
		              (piVar2,piVar1,*(undefined4 *)(iVar3 + 0x124));
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe0) * 4))
		              (piVar2,*(int *)(param1 + 0xc),piVar1,*(undefined4 *)(iVar3 + 0xe4));
		  }
		  *(undefined4 *)(param1 + 8) = 0;
		  return;
		}
		*/


		/* --- GHIDRA: set_AsDouble ---
		undefined4 I2_Loc_SimpleJSON_JSONLazyCreator__set_AsDouble(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a54e86 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONData_TypeInfo);
		    DAT_ram_00a54e86 = '\x01';
		  }
		  piVar1 = (int *)unnamed_function_1417(I2_Loc_SimpleJSON_JSONData_TypeInfo);
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x188) * 4))
		            (piVar1,0,*(undefined4 *)(*piVar1 + 0x18c));
		  piVar2 = *(int **)(param1 + 8);
		  iVar3 = *piVar2;
		  if (*(int *)(param1 + 0xc) == 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x120) * 4))
		              (piVar2,piVar1,*(undefined4 *)(iVar3 + 0x124));
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe0) * 4))
		              (piVar2,*(int *)(param1 + 0xc),piVar1,*(undefined4 *)(iVar3 + 0xe4));
		  }
		  *(undefined4 *)(param1 + 8) = 0;
		  return 0;
		}
		*/


		/* --- GHIDRA: get_AsBool ---
		void I2_Loc_SimpleJSON_JSONLazyCreator__get_AsBool(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a54e87 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONData_TypeInfo);
		    DAT_ram_00a54e87 = '\x01';
		  }
		  piVar1 = (int *)unnamed_function_1417(I2_Loc_SimpleJSON_JSONData_TypeInfo);
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x188) * 4))
		            (piVar1,param2,*(undefined4 *)(*piVar1 + 0x18c));
		  piVar2 = *(int **)(param1 + 8);
		  iVar3 = *piVar2;
		  if (*(int *)(param1 + 0xc) == 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x120) * 4))
		              (piVar2,piVar1,*(undefined4 *)(iVar3 + 0x124));
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe0) * 4))
		              (piVar2,*(int *)(param1 + 0xc),piVar1,*(undefined4 *)(iVar3 + 0xe4));
		  }
		  *(undefined4 *)(param1 + 8) = 0;
		  return;
		}
		*/


		/* --- GHIDRA: set_AsBool ---
		int I2_Loc_SimpleJSON_JSONLazyCreator__set_AsBool(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a54e88 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONArray_TypeInfo);
		    DAT_ram_00a54e88 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(I2_Loc_SimpleJSON_JSONArray_TypeInfo);
		  if (DAT_ram_00a54e5a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_JSONNode___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_JSONNode__TypeInfo);
		    DAT_ram_00a54e5a = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_JSONNode__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_JSONNode___ctor__);
		  *(undefined4 *)(iVar1 + 8) = param1_00;
		  piVar2 = *(int **)(param1 + 8);
		  iVar3 = *piVar2;
		  if (*(int *)(param1 + 0xc) == 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x120) * 4))
		              (piVar2,iVar1,*(undefined4 *)(iVar3 + 0x124));
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe0) * 4))
		              (piVar2,*(int *)(param1 + 0xc),iVar1,*(undefined4 *)(iVar3 + 0xe4));
		  }
		  *(undefined4 *)(param1 + 8) = 0;
		  return iVar1;
		}
		*/


		/* --- GHIDRA: get_AsArray ---
		undefined4 I2_Loc_SimpleJSON_JSONLazyCreator__get_AsArray(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *piVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a54e89 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONClass_TypeInfo);
		    DAT_ram_00a54e89 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(I2_Loc_SimpleJSON_JSONClass_TypeInfo);
		  I2_Loc_SimpleJSON_JSONClass__Serialize(param1_00,param1);
		  piVar1 = *(int **)(param1 + 8);
		  iVar2 = *piVar1;
		  if (*(int *)(param1 + 0xc) == 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x120) * 4))
		              (piVar1,param1_00,*(undefined4 *)(iVar2 + 0x124));
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe0) * 4))
		              (piVar1,*(int *)(param1 + 0xc),param1_00,*(undefined4 *)(iVar2 + 0xe4));
		  }
		  *(undefined4 *)(param1 + 8) = 0;
		  return param1_00;
		}
		*/


		/* --- GHIDRA: get_AsObject ---
		undefined4 I2_Loc_SimpleJSON_JSONLazyCreator__get_AsObject(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = I2_Loc_SimpleJSON_JSONNode__GetHashCode(param1,param1);
		  return uVar1;
		}
		*/

}
