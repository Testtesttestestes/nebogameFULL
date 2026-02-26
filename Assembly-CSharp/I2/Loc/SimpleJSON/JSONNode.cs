using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace I2.Loc.SimpleJSON
{
	// Token: 0x020013B9 RID: 5049
	[Token(Token = "0x20013B9")]
	public class JSONNode
	{
		// Token: 0x060077FC RID: 30716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077FC")]
		[Address(RVA = "0xC151", Offset = "0xC151", VA = "0xC151", Slot = "4")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		// Token: 0x170017B8 RID: 6072
		[Token(Token = "0x170017B8")]
		public virtual JSONNode this[int aIndex]
		{
			[Token(Token = "0x60077FD")]
			[Address(RVA = "0xC152", Offset = "0xC152", VA = "0xC152", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60077FE")]
			[Address(RVA = "0xC153", Offset = "0xC153", VA = "0xC153", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x170017B9 RID: 6073
		[Token(Token = "0x170017B9")]
		public virtual JSONNode this[string aKey]
		{
			[Token(Token = "0x60077FF")]
			[Address(RVA = "0xC154", Offset = "0xC154", VA = "0xC154", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007800")]
			[Address(RVA = "0xC155", Offset = "0xC155", VA = "0xC155", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x170017BA RID: 6074
		// (get) Token: 0x06007801 RID: 30721 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06007802 RID: 30722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017BA")]
		public virtual string Value
		{
			[Token(Token = "0x6007801")]
			[Address(RVA = "0xC156", Offset = "0xC156", VA = "0xC156", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007802")]
			[Address(RVA = "0xC157", Offset = "0xC157", VA = "0xC157", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x170017BB RID: 6075
		// (get) Token: 0x06007803 RID: 30723 RVA: 0x00016098 File Offset: 0x00014298
		[Token(Token = "0x170017BB")]
		public virtual int Count
		{
			[Token(Token = "0x6007803")]
			[Address(RVA = "0xC158", Offset = "0xC158", VA = "0xC158", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06007804 RID: 30724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007804")]
		[Address(RVA = "0xC159", Offset = "0xC159", VA = "0xC159", Slot = "12")]
		public virtual void Add(JSONNode aItem)
		{
		}

		// Token: 0x06007805 RID: 30725 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007805")]
		[Address(RVA = "0xC15A", Offset = "0xC15A", VA = "0xC15A", Slot = "13")]
		public virtual JSONNode Remove(string aKey)
		{
		/* --- GHIDRA: Remove ---
		int I2_Loc_SimpleJSON_JSONNode__Remove(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a54e36 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONNode__get_Childs_d__17_TypeInfo);
		    DAT_ram_00a54e36 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(I2_Loc_SimpleJSON_JSONNode__get_Childs_d__17_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = 0xfffffffe;
		  uVar2 = func_ii_6393(0);
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  return iVar1;
		}
		*/

		/* --- GHIDRA: Remove ---
		int I2_Loc_SimpleJSON_JSONNode__Remove(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a54e36 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONNode__get_Childs_d__17_TypeInfo);
		    DAT_ram_00a54e36 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(I2_Loc_SimpleJSON_JSONNode__get_Childs_d__17_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = 0xfffffffe;
		  uVar2 = func_ii_6393(0);
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  return iVar1;
		}
		*/

		/* --- GHIDRA: Remove ---
		int I2_Loc_SimpleJSON_JSONNode__Remove(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a54e36 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONNode__get_Childs_d__17_TypeInfo);
		    DAT_ram_00a54e36 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(I2_Loc_SimpleJSON_JSONNode__get_Childs_d__17_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = 0xfffffffe;
		  uVar2 = func_ii_6393(0);
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06007806 RID: 30726 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007806")]
		[Address(RVA = "0xC15B", Offset = "0xC15B", VA = "0xC15B", Slot = "14")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		// Token: 0x06007807 RID: 30727 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007807")]
		[Address(RVA = "0xC15C", Offset = "0xC15C", VA = "0xC15C", Slot = "15")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		// Token: 0x170017BC RID: 6076
		// (get) Token: 0x06007808 RID: 30728 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017BC")]
		public virtual IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6007808")]
			[Address(RVA = "0xC15D", Offset = "0xC15D", VA = "0xC15D", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x170017BD RID: 6077
		// (get) Token: 0x06007809 RID: 30729 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017BD")]
		public IEnumerable<JSONNode> DeepChilds
		{
			[Token(Token = "0x6007809")]
			[Address(RVA = "0xC15E", Offset = "0xC15E", VA = "0xC15E")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600780A RID: 30730 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600780A")]
		[Address(RVA = "0xC15F", Offset = "0xC15F", VA = "0xC15F", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		undefined4 I2_Loc_SimpleJSON_JSONNode__ToString(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 local_4;
		  
		  local_4 = 0;
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x108) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x10c));
		  iVar1 = System_Net_WebHeaderCollection__Add(param1_00,&local_4,0);
		  if (iVar1 == 0) {
		    local_4 = 0;
		  }
		  return local_4;
		}
		*/

		/* --- GHIDRA: ToString ---
		undefined4 I2_Loc_SimpleJSON_JSONNode__ToString(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 local_4;
		  
		  local_4 = 0;
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x108) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x10c));
		  iVar1 = System_Net_WebHeaderCollection__Add(param1_00,&local_4,0);
		  if (iVar1 == 0) {
		    local_4 = 0;
		  }
		  return local_4;
		}
		*/

			return null;
		}

		// Token: 0x0600780B RID: 30731 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600780B")]
		[Address(RVA = "0xC160", Offset = "0xC160", VA = "0xC160", Slot = "17")]
		public virtual string ToString(string aPrefix)
		{
			return null;
		}

		// Token: 0x170017BE RID: 6078
		// (get) Token: 0x0600780C RID: 30732 RVA: 0x000160B0 File Offset: 0x000142B0
		// (set) Token: 0x0600780D RID: 30733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017BE")]
		public virtual int AsInt
		{
			[Token(Token = "0x600780C")]
			[Address(RVA = "0xC161", Offset = "0xC161", VA = "0xC161", Slot = "18")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600780D")]
			[Address(RVA = "0xC162", Offset = "0xC162", VA = "0xC162", Slot = "19")]
			set
			{
			}
		}

		// Token: 0x170017BF RID: 6079
		// (get) Token: 0x0600780E RID: 30734 RVA: 0x000160C8 File Offset: 0x000142C8
		// (set) Token: 0x0600780F RID: 30735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017BF")]
		public virtual float AsFloat
		{
			[Token(Token = "0x600780E")]
			[Address(RVA = "0xC163", Offset = "0xC163", VA = "0xC163", Slot = "20")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600780F")]
			[Address(RVA = "0xC164", Offset = "0xC164", VA = "0xC164", Slot = "21")]
			set
			{
			}
		}

		// Token: 0x170017C0 RID: 6080
		// (get) Token: 0x06007810 RID: 30736 RVA: 0x000160E0 File Offset: 0x000142E0
		// (set) Token: 0x06007811 RID: 30737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017C0")]
		public virtual double AsDouble
		{
			[Token(Token = "0x6007810")]
			[Address(RVA = "0xC165", Offset = "0xC165", VA = "0xC165", Slot = "22")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6007811")]
			[Address(RVA = "0xC166", Offset = "0xC166", VA = "0xC166", Slot = "23")]
			set
			{
			}
		}

		// Token: 0x170017C1 RID: 6081
		// (get) Token: 0x06007812 RID: 30738 RVA: 0x000160F8 File Offset: 0x000142F8
		// (set) Token: 0x06007813 RID: 30739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017C1")]
		public virtual bool AsBool
		{
			[Token(Token = "0x6007812")]
			[Address(RVA = "0xC167", Offset = "0xC167", VA = "0xC167", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007813")]
			[Address(RVA = "0xC168", Offset = "0xC168", VA = "0xC168", Slot = "25")]
			set
			{
			}
		}

		// Token: 0x170017C2 RID: 6082
		// (get) Token: 0x06007814 RID: 30740 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017C2")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x6007814")]
			[Address(RVA = "0xC169", Offset = "0xC169", VA = "0xC169", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x170017C3 RID: 6083
		// (get) Token: 0x06007815 RID: 30741 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017C3")]
		public virtual JSONClass AsObject
		{
			[Token(Token = "0x6007815")]
			[Address(RVA = "0xC16A", Offset = "0xC16A", VA = "0xC16A", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007816 RID: 30742 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007816")]
		[Address(RVA = "0xC16B", Offset = "0xC16B", VA = "0xC16B")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		// Token: 0x06007817 RID: 30743 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007817")]
		[Address(RVA = "0xC16C", Offset = "0xC16C", VA = "0xC16C")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		// Token: 0x06007818 RID: 30744 RVA: 0x00016110 File Offset: 0x00014310
		[Token(Token = "0x6007818")]
		[Address(RVA = "0xC16D", Offset = "0xC16D", VA = "0xC16D")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		// Token: 0x06007819 RID: 30745 RVA: 0x00016128 File Offset: 0x00014328
		[Token(Token = "0x6007819")]
		[Address(RVA = "0xC16E", Offset = "0xC16E", VA = "0xC16E")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}

		// Token: 0x0600781A RID: 30746 RVA: 0x00016140 File Offset: 0x00014340
		[Token(Token = "0x600781A")]
		[Address(RVA = "0xC16F", Offset = "0xC16F", VA = "0xC16F", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600781B RID: 30747 RVA: 0x00016158 File Offset: 0x00014358
		[Token(Token = "0x600781B")]
		[Address(RVA = "0xC170", Offset = "0xC170", VA = "0xC170", Slot = "2")]
		public override int GetHashCode()
		{
		/* --- GHIDRA: GetHashCode ---
		int * I2_Loc_SimpleJSON_JSONNode__GetHashCode(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  bool bVar2;
		  int param1_00;
		  uint uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  undefined4 uVar7;
		  int iVar8;
		  int iVar9;
		  undefined2 local_4;
		  undefined2 local_2;
		  
		  bVar1 = false;
		  piVar6 = (int *)0x0;
		  iVar9 = 0;
		  if (DAT_ram_00a54e40 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONArray_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONClass_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Stack_JSONNode__Peek__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Stack_JSONNode__Pop__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Stack_JSONNode__Push__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Stack_JSONNode___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Stack_JSONNode__get_Count__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Stack_JSONNode__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_47);
		    Mono_Security_ASN1__get_Item(&StringLiteral_41);
		    Mono_Security_ASN1__get_Item(&StringLiteral_42);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    Mono_Security_ASN1__get_Item(&StringLiteral_91);
		    Mono_Security_ASN1__get_Item(&StringLiteral_90);
		    DAT_ram_00a54e40 = '\x01';
		  }
		  local_2 = 0;
		  local_4 = 0;
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Stack_JSONNode__TypeInfo);
		  Sirenix_Serialization_StackFormatter_object____Il2CppFullySharedGenericType___SerializeImplementation
		            (param1_00,Method_System_Collections_Generic_Stack_JSONNode___ctor__);
		  uVar5 = StringLiteral_5;
		  uVar7 = StringLiteral_5;
		  if (0 < *(int *)(param1 + 8)) {
		    do {
		      uVar3 = func_ii_3010(param1,iVar9,0);
		      uVar4 = uVar5;
		      iVar8 = iVar9;
		      bVar2 = bVar1;
		      if (uVar3 < 0x2d) {
		        if (uVar3 < 0x21) {
		          if (uVar3 == 9) {
		code_r0x80b25929:
		            bVar2 = false;
		            if (bVar1) {
		              uVar4 = func_ii_3010(param1,iVar9,0);
		              local_2 = (undefined2)uVar4;
		              if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		                func_ii_306000(DAT_ram_00a66974);
		              }
		              uVar4 = System_Text_StringBuilder___ctor(&local_2,0);
		              uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar5,uVar4,0);
		              bVar2 = true;
		            }
		          }
		          else if (uVar3 != 10) {
		            if ((uVar3 != 0xb) && (uVar3 != 0xc)) {
		              if (uVar3 == 0xd) goto code_r0x80b25b3c;
		              if (((((uVar3 != 0xe) && (uVar3 != 0xf)) && (uVar3 != 0x10)) &&
		                  ((uVar3 != 0x11 && (uVar3 != 0x12)))) &&
		                 (((((uVar3 != 0x13 && ((uVar3 != 0x14 && (uVar3 != 0x15)))) && (uVar3 != 0x16)) &&
		                   (((((uVar3 != 0x17 && (uVar3 != 0x18)) && (uVar3 != 0x19)) &&
		                     (((uVar3 != 0x1a && (uVar3 != 0x1b)) &&
		                      ((uVar3 != 0x1c && ((uVar3 != 0x1d && (uVar3 != 0x1e)))))))) &&
		                    (uVar3 != 0x1f)))) && (uVar3 == 0x20)))) goto code_r0x80b25929;
		            }
		code_r0x80b25b00:
		            uVar4 = func_ii_3010(param1,iVar9,0);
		            local_2 = (undefined2)uVar4;
		            if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		              func_ii_306000(DAT_ram_00a66974);
		            }
		            uVar4 = System_Text_StringBuilder___ctor(&local_2,0);
		            uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar5,uVar4,0);
		          }
		        }
		        else if (uVar3 == 0x22) {
		          bVar2 = (bool)(bVar1 ^ 1);
		        }
		        else {
		          if (((((uVar3 == 0x23) || (uVar3 == 0x24)) || (uVar3 == 0x25)) ||
		              (((uVar3 == 0x26 || (uVar3 == 0x27)) ||
		               ((uVar3 == 0x28 || ((uVar3 == 0x29 || (uVar3 == 0x2a)))))))) ||
		             ((uVar3 == 0x2b || (uVar3 != 0x2c)))) goto code_r0x80b25b00;
		          if (bVar1) {
		            uVar4 = func_ii_3010(param1,iVar9,0);
		            local_2 = (undefined2)uVar4;
		            if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		              func_ii_306000(DAT_ram_00a66974);
		            }
		            uVar4 = System_Text_StringBuilder___ctor(&local_2,0);
		            uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar5,uVar4,0);
		            bVar2 = true;
		          }
		          else {
		            iVar9 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                              (uVar5,StringLiteral_5,0);
		            if (iVar9 != 0) {
		              if (piVar6 != (int *)0x0) {
		                if (((uint)*(byte *)(I2_Loc_SimpleJSON_JSONArray_TypeInfo + 0xb8) <=
		                     (uint)*(byte *)(*piVar6 + 0xb8)) &&
		                   (*(int *)(*(int *)(*piVar6 + 100) +
		                             (uint)*(byte *)(I2_Loc_SimpleJSON_JSONArray_TypeInfo + 0xb8) * 4 + -4)
		                    == I2_Loc_SimpleJSON_JSONArray_TypeInfo)) {
		                  if (DAT_ram_00a54e3d == '\0') {
		                    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONData_TypeInfo);
		                    DAT_ram_00a54e3d = '\x01';
		                  }
		                  iVar9 = unnamed_function_1417(I2_Loc_SimpleJSON_JSONData_TypeInfo);
		                  *(undefined4 *)(iVar9 + 8) = uVar5;
		                  (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x120) * 4))
		                            (piVar6,iVar9,*(undefined4 *)(*piVar6 + 0x124));
		                  goto code_r0x80b25916;
		                }
		              }
		              iVar9 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                                (uVar7,StringLiteral_5,0);
		              if (iVar9 != 0) {
		                if (DAT_ram_00a54e3d == '\0') {
		                  Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONData_TypeInfo);
		                  DAT_ram_00a54e3d = '\x01';
		                }
		                iVar9 = unnamed_function_1417(I2_Loc_SimpleJSON_JSONData_TypeInfo);
		                *(undefined4 *)(iVar9 + 8) = uVar5;
		                (**(code **)((ulonglong)*(uint *)(*piVar6 + 0xe0) * 4))
		                          (piVar6,uVar7,iVar9,*(undefined4 *)(*piVar6 + 0xe4));
		              }
		            }
		code_r0x80b25916:
		            uVar4 = StringLiteral_5;
		            uVar7 = StringLiteral_5;
		            bVar2 = false;
		          }
		        }
		      }
		      else if (uVar3 < 0x5e) {
		        if (uVar3 == 0x3a) {
		          if (bVar1) {
		            uVar4 = func_ii_3010(param1,iVar9,0);
		            local_2 = (undefined2)uVar4;
		            if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		              func_ii_306000(DAT_ram_00a66974);
		            }
		            uVar4 = System_Text_StringBuilder___ctor(&local_2,0);
		            uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar5,uVar4,0);
		            bVar2 = true;
		          }
		          else {
		            uVar4 = StringLiteral_5;
		            uVar7 = uVar5;
		            bVar2 = false;
		          }
		        }
		        else {
		          if (((((((uVar3 == 0x3b) || (uVar3 == 0x3c)) || (uVar3 == 0x3d)) ||
		                ((uVar3 == 0x3e || (uVar3 == 0x3f)))) || (uVar3 == 0x40)) ||
		              (((((uVar3 == 0x41 || (uVar3 == 0x42)) ||
		                 ((uVar3 == 0x43 || (((uVar3 == 0x44 || (uVar3 == 0x45)) || (uVar3 == 0x46)))))) ||
		                ((uVar3 == 0x47 || (uVar3 == 0x48)))) || (uVar3 == 0x49)))) ||
		             ((((uVar3 == 0x4a || (uVar3 == 0x4b)) ||
		               ((uVar3 == 0x4c || (((uVar3 == 0x4d || (uVar3 == 0x4e)) || (uVar3 == 0x4f)))))) ||
		              (((uVar3 == 0x50 || (uVar3 == 0x51)) ||
		               ((uVar3 == 0x52 ||
		                (((uVar3 == 0x53 || (uVar3 == 0x54)) ||
		                 ((uVar3 == 0x55 ||
		                  ((((uVar3 == 0x56 || (uVar3 == 0x57)) || (uVar3 == 0x58)) ||
		                   ((uVar3 == 0x59 || (uVar3 == 0x5a)))))))))))))))) goto code_r0x80b25b00;
		          if (uVar3 == 0x5b) {
		            if (bVar1) {
		              uVar4 = func_ii_3010(param1,iVar9,0);
		              local_2 = (undefined2)uVar4;
		              if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		                func_ii_306000(DAT_ram_00a66974);
		              }
		              uVar4 = System_Text_StringBuilder___ctor(&local_2,0);
		              uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar5,uVar4,0);
		              bVar2 = true;
		            }
		            else {
		              iVar9 = unnamed_function_1417(I2_Loc_SimpleJSON_JSONArray_TypeInfo);
		              if (DAT_ram_00a54e5a == '\0') {
		                Mono_Security_ASN1__get_Item
		                          (&Method_System_Collections_Generic_List_JSONNode___ctor__);
		                Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_JSONNode__TypeInfo);
		                DAT_ram_00a54e5a = '\x01';
		              }
		              uVar5 = unnamed_function_1417(System_Collections_Generic_List_JSONNode__TypeInfo);
		              GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		                        (uVar5,Method_System_Collections_Generic_List_JSONNode___ctor__);
		              *(undefined4 *)(iVar9 + 8) = uVar5;
		              System_Linq_Expressions_Expression__Parameter
		                        (param1_00,iVar9,Method_System_Collections_Generic_Stack_JSONNode__Push__);
		              if (DAT_ram_00a54e3e == '\0') {
		                Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONLazyCreator_TypeInfo);
		                DAT_ram_00a54e3e = '\x01';
		              }
		              if (piVar6 != (int *)0x0) {
		                if (((uint)*(byte *)(*piVar6 + 0xb8) <
		                     (uint)*(byte *)(I2_Loc_SimpleJSON_JSONLazyCreator_TypeInfo + 0xb8)) ||
		                   (*(int *)(*(int *)(*piVar6 + 100) +
		                             (uint)*(byte *)(I2_Loc_SimpleJSON_JSONLazyCreator_TypeInfo + 0xb8) * 4
		                            + -4) != I2_Loc_SimpleJSON_JSONLazyCreator_TypeInfo)) {
		                  uVar5 = System_Convert__FromBase64String(uVar7,0);
		                  if (((uint)*(byte *)(*piVar6 + 0xb8) <
		                       (uint)*(byte *)(I2_Loc_SimpleJSON_JSONArray_TypeInfo + 0xb8)) ||
		                     (*(int *)(*(int *)(*piVar6 + 100) +
		                               (uint)*(byte *)(I2_Loc_SimpleJSON_JSONArray_TypeInfo + 0xb8) * 4 + -4
		                              ) != I2_Loc_SimpleJSON_JSONArray_TypeInfo)) {
		                    iVar9 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                                      (uVar5,StringLiteral_5,0);
		                    if (iVar9 != 0) {
		                      uVar7 = Newtonsoft_Json_Utilities_ThreadSafeStore_object__object___Get
		                                        (param1_00,
		                                         Method_System_Collections_Generic_Stack_JSONNode__Peek__);
		                      (**(code **)((ulonglong)*(uint *)(*piVar6 + 0xe0) * 4))
		                                (piVar6,uVar5,uVar7,*(undefined4 *)(*piVar6 + 0xe4));
		                    }
		                  }
		                  else {
		                    uVar5 = Newtonsoft_Json_Utilities_ThreadSafeStore_object__object___Get
		                                      (param1_00,
		                                       Method_System_Collections_Generic_Stack_JSONNode__Peek__);
		                    (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x120) * 4))
		                              (piVar6,uVar5,*(undefined4 *)(*piVar6 + 0x124));
		                  }
		                }
		              }
		              uVar4 = StringLiteral_5;
		              piVar6 = (int *)Newtonsoft_Json_Utilities_ThreadSafeStore_object__object___Get
		                                        (param1_00,
		                                         Method_System_Collections_Generic_Stack_JSONNode__Peek__);
		              uVar7 = uVar4;
		              bVar2 = false;
		            }
		          }
		          else {
		            if (uVar3 != 0x5c) {
		              if (uVar3 == 0x5d) goto code_r0x80b255d3;
		              goto code_r0x80b25b00;
		            }
		            iVar8 = iVar9 + 1;
		            bVar2 = false;
		            if (bVar1) {
		              uVar3 = func_ii_3010(param1,iVar8,0);
		              local_4 = (undefined2)uVar3;
		              if (uVar3 < 0x67) {
		                if (uVar3 == 0x62) {
		                  uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar5,StringLiteral_41,0);
		                  bVar2 = true;
		                }
		                else {
		                  if ((((uVar3 == 99) || (uVar3 == 100)) || (uVar3 == 0x65)) || (uVar3 != 0x66))
		                  goto code_r0x80b25ac9;
		                  uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar5,StringLiteral_90,0);
		                  bVar2 = true;
		                }
		              }
		              else if (uVar3 == 0x6e) {
		                uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar5,StringLiteral_47,0);
		                bVar2 = true;
		              }
		              else if (((uVar3 == 0x6f) || (uVar3 == 0x70)) || (uVar3 == 0x71)) {
		code_r0x80b25ac9:
		                if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		                  func_ii_306000(DAT_ram_00a66974);
		                }
		                uVar4 = System_Text_StringBuilder___ctor(&local_4,0);
		                uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar5,uVar4,0);
		                bVar2 = true;
		              }
		              else if (uVar3 == 0x72) {
		                uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar5,StringLiteral_91,0);
		                bVar2 = true;
		              }
		              else {
		                if (uVar3 == 0x73) goto code_r0x80b25ac9;
		                if (uVar3 == 0x74) {
		                  uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar5,StringLiteral_42,0);
		                  bVar2 = true;
		                }
		                else {
		                  if (uVar3 != 0x75) goto code_r0x80b25ac9;
		                  uVar4 = System_Data_DataSet__ReadXmlSchema(param1,iVar9 + 2,4,0);
		                  uVar4 = func_ii_11502(uVar4,0x200,0);
		                  local_2 = (undefined2)uVar4;
		                  if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		                    func_ii_306000(DAT_ram_00a66974);
		                  }
		                  uVar4 = System_Text_StringBuilder___ctor(&local_2,0);
		                  uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar5,uVar4,0);
		                  iVar8 = iVar9 + 5;
		                  bVar2 = true;
		                }
		              }
		            }
		          }
		        }
		      }
		      else if (uVar3 == 0x7b) {
		        if (bVar1) {
		          uVar4 = func_ii_3010(param1,iVar9,0);
		          local_2 = (undefined2)uVar4;
		          if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		            func_ii_306000(DAT_ram_00a66974);
		          }
		          uVar4 = System_Text_StringBuilder___ctor(&local_2,0);
		          uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar5,uVar4,0);
		          bVar2 = true;
		        }
		        else {
		          uVar5 = unnamed_function_1417(I2_Loc_SimpleJSON_JSONClass_TypeInfo);
		          I2_Loc_SimpleJSON_JSONClass__Serialize(uVar5,iVar9);
		          System_Linq_Expressions_Expression__Parameter
		                    (param1_00,uVar5,Method_System_Collections_Generic_Stack_JSONNode__Push__);
		          if (DAT_ram_00a54e3e == '\0') {
		            Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONLazyCreator_TypeInfo);
		            DAT_ram_00a54e3e = '\x01';
		          }
		          if (piVar6 != (int *)0x0) {
		            if (((uint)*(byte *)(*piVar6 + 0xb8) <
		                 (uint)*(byte *)(I2_Loc_SimpleJSON_JSONLazyCreator_TypeInfo + 0xb8)) ||
		               (*(int *)(*(int *)(*piVar6 + 100) +
		                         (uint)*(byte *)(I2_Loc_SimpleJSON_JSONLazyCreator_TypeInfo + 0xb8) * 4 + -4
		                        ) != I2_Loc_SimpleJSON_JSONLazyCreator_TypeInfo)) {
		              uVar5 = System_Convert__FromBase64String(uVar7,0);
		              if (((uint)*(byte *)(*piVar6 + 0xb8) <
		                   (uint)*(byte *)(I2_Loc_SimpleJSON_JSONArray_TypeInfo + 0xb8)) ||
		                 (*(int *)(*(int *)(*piVar6 + 100) +
		                           (uint)*(byte *)(I2_Loc_SimpleJSON_JSONArray_TypeInfo + 0xb8) * 4 + -4) !=
		                  I2_Loc_SimpleJSON_JSONArray_TypeInfo)) {
		                iVar9 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                                  (uVar5,StringLiteral_5,0);
		                if (iVar9 != 0) {
		                  uVar7 = Newtonsoft_Json_Utilities_ThreadSafeStore_object__object___Get
		                                    (param1_00,
		                                     Method_System_Collections_Generic_Stack_JSONNode__Peek__);
		                  (**(code **)((ulonglong)*(uint *)(*piVar6 + 0xe0) * 4))
		                            (piVar6,uVar5,uVar7,*(undefined4 *)(*piVar6 + 0xe4));
		                }
		              }
		              else {
		                uVar5 = Newtonsoft_Json_Utilities_ThreadSafeStore_object__object___Get
		                                  (param1_00,
		                                   Method_System_Collections_Generic_Stack_JSONNode__Peek__);
		                (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x120) * 4))
		                          (piVar6,uVar5,*(undefined4 *)(*piVar6 + 0x124));
		              }
		            }
		          }
		          uVar4 = StringLiteral_5;
		          piVar6 = (int *)Newtonsoft_Json_Utilities_ThreadSafeStore_object__object___Get
		                                    (param1_00,
		                                     Method_System_Collections_Generic_Stack_JSONNode__Peek__);
		          uVar7 = uVar4;
		          bVar2 = false;
		        }
		      }
		      else {
		        if ((uVar3 == 0x7c) || (uVar3 != 0x7d)) goto code_r0x80b25b00;
		code_r0x80b255d3:
		        if (bVar1) {
		          uVar4 = func_ii_3010(param1,iVar9,0);
		          local_2 = (undefined2)uVar4;
		          if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		            func_ii_306000(DAT_ram_00a66974);
		          }
		          uVar4 = System_Text_StringBuilder___ctor(&local_2,0);
		          uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar5,uVar4,0);
		          bVar2 = true;
		        }
		        else {
		          if (*(int *)(param1_00 + 0xc) == 0) {
		            uVar5 = unnamed_function_2232(&System_Exception_TypeInfo);
		            uVar5 = unnamed_function_1417(uVar5);
		            uVar7 = unnamed_function_2232(&StringLiteral_10059);
		            System_String__Concat(uVar5,uVar7,0);
		            uVar7 = unnamed_function_2232(&Method_I2_Loc_SimpleJSON_JSONNode_Parse__);
		            func_ii_1050(uVar5,uVar7);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          System_Linq_Expressions_Interpreter_LightCompiler__CompileAsVoid
		                    (param1_00,Method_System_Collections_Generic_Stack_JSONNode__Pop__);
		          iVar9 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                            (uVar5,StringLiteral_5,0);
		          if (iVar9 != 0) {
		            uVar7 = System_Convert__FromBase64String(uVar7,0);
		            if (piVar6 != (int *)0x0) {
		              if (((uint)*(byte *)(I2_Loc_SimpleJSON_JSONArray_TypeInfo + 0xb8) <=
		                   (uint)*(byte *)(*piVar6 + 0xb8)) &&
		                 (*(int *)(*(int *)(*piVar6 + 100) +
		                           (uint)*(byte *)(I2_Loc_SimpleJSON_JSONArray_TypeInfo + 0xb8) * 4 + -4) ==
		                  I2_Loc_SimpleJSON_JSONArray_TypeInfo)) {
		                if (DAT_ram_00a54e3d == '\0') {
		                  Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONData_TypeInfo);
		                  DAT_ram_00a54e3d = '\x01';
		                }
		                iVar9 = unnamed_function_1417(I2_Loc_SimpleJSON_JSONData_TypeInfo);
		                *(undefined4 *)(iVar9 + 8) = uVar5;
		                (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x120) * 4))
		                          (piVar6,iVar9,*(undefined4 *)(*piVar6 + 0x124));
		                goto code_r0x80b25736;
		              }
		            }
		            iVar9 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                              (uVar7,StringLiteral_5,0);
		            if (iVar9 != 0) {
		              if (DAT_ram_00a54e3d == '\0') {
		                Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONData_TypeInfo);
		                DAT_ram_00a54e3d = '\x01';
		              }
		              iVar9 = unnamed_function_1417(I2_Loc_SimpleJSON_JSONData_TypeInfo);
		              *(undefined4 *)(iVar9 + 8) = uVar5;
		              (**(code **)((ulonglong)*(uint *)(*piVar6 + 0xe0) * 4))
		                        (piVar6,uVar7,iVar9,*(undefined4 *)(*piVar6 + 0xe4));
		            }
		          }
		code_r0x80b25736:
		          uVar4 = StringLiteral_5;
		          uVar7 = uVar4;
		          bVar2 = false;
		          if (0 < *(int *)(param1_00 + 0xc)) {
		            piVar6 = (int *)Newtonsoft_Json_Utilities_ThreadSafeStore_object__object___Get
		                                      (param1_00,
		                                       Method_System_Collections_Generic_Stack_JSONNode__Peek__);
		          }
		        }
		      }
		code_r0x80b25b3c:
		      bVar1 = bVar2;
		      iVar9 = iVar8 + 1;
		      uVar5 = uVar4;
		    } while (iVar9 < *(int *)(param1 + 8));
		    if (bVar1) {
		      uVar5 = unnamed_function_2232(&System_Exception_TypeInfo);
		      uVar5 = unnamed_function_1417(uVar5);
		      uVar7 = unnamed_function_2232(&StringLiteral_10058);
		      System_String__Concat(uVar5,uVar7,0);
		      uVar7 = unnamed_function_2232(&Method_I2_Loc_SimpleJSON_JSONNode_Parse__);
		      func_ii_1050(uVar5,uVar7);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return piVar6;
		}
		*/

			return 0;
		}

		// Token: 0x0600781C RID: 30748 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600781C")]
		[Address(RVA = "0x1904", Offset = "0x1904", VA = "0x1904")]
		internal static string Escape(string aText)
		{
		/* --- GHIDRA: Escape ---
		int * I2_Loc_SimpleJSON_JSONNode__Escape(int *param1)
		
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

		// Token: 0x0600781D RID: 30749 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600781D")]
		[Address(RVA = "0xC171", Offset = "0xC171", VA = "0xC171")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		// Token: 0x0600781E RID: 30750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600781E")]
		[Address(RVA = "0xC172", Offset = "0xC172", VA = "0xC172", Slot = "28")]
		public virtual void Serialize(BinaryWriter aWriter)
		{
		/* --- GHIDRA: Serialize ---
		void I2_Loc_SimpleJSON_JSONNode__Serialize(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a54e41 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IO_BinaryWriter_TypeInfo);
		    DAT_ram_00a54e41 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_IO_BinaryWriter_TypeInfo);
		  System_String__CreateString(param1_00,param2,0);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x1a0) * 4))
		            (param1,param1_00,*(undefined4 *)(*param1 + 0x1a4));
		  return;
		}
		*/

		}

		// Token: 0x0600781F RID: 30751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600781F")]
		[Address(RVA = "0xC173", Offset = "0xC173", VA = "0xC173")]
		public void SaveToStream(Stream aData)
		{
		/* --- GHIDRA: SaveToStream ---
		void I2_Loc_SimpleJSON_JSONNode__SaveToStream(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  uVar1 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  uVar2 = unnamed_function_2232(&StringLiteral_4665);
		  System_String__Concat(uVar1,uVar2,0);
		  uVar2 = unnamed_function_2232(&Method_I2_Loc_SimpleJSON_JSONNode_SaveToCompressedStream__);
		  func_ii_1050(uVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06007820 RID: 30752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007820")]
		[Address(RVA = "0xC174", Offset = "0xC174", VA = "0xC174")]
		public void SaveToCompressedStream(Stream aData)
		{
		/* --- GHIDRA: SaveToCompressedStream ---
		void I2_Loc_SimpleJSON_JSONNode__SaveToCompressedStream
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  uVar1 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  uVar2 = unnamed_function_2232(&StringLiteral_4665);
		  System_String__Concat(uVar1,uVar2,0);
		  uVar2 = unnamed_function_2232(&Method_I2_Loc_SimpleJSON_JSONNode_SaveToCompressedFile__);
		  func_ii_1050(uVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06007821 RID: 30753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007821")]
		[Address(RVA = "0xC175", Offset = "0xC175", VA = "0xC175")]
		public void SaveToCompressedFile(string aFileName)
		{
		/* --- GHIDRA: SaveToCompressedFile ---
		undefined4 I2_Loc_SimpleJSON_JSONNode__SaveToCompressedFile(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  uVar1 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  uVar2 = unnamed_function_2232(&StringLiteral_4665);
		  System_String__Concat(uVar1,uVar2,0);
		  uVar2 = unnamed_function_2232(&Method_I2_Loc_SimpleJSON_JSONNode_SaveToCompressedBase64__);
		  func_ii_1050(uVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06007822 RID: 30754 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007822")]
		[Address(RVA = "0xC176", Offset = "0xC176", VA = "0xC176")]
		public string SaveToCompressedBase64()
		{
		/* --- GHIDRA: SaveToCompressedBase64 ---
		void I2_Loc_SimpleJSON_JSONNode__SaveToCompressedBase64
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  uint *puVar5;
		  int iVar6;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  iVar6 = 0;
		  if (DAT_ram_00a54e42 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IO_FileInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    DAT_ram_00a54e42 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(System_IO_FileInfo_TypeInfo);
		  System_IO_FileInfo___ctor(uVar2,param2,0);
		  piVar3 = (int *)System_IO_FileInfo__get_DirectoryName(uVar2,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		                    (piVar3,*(undefined4 *)(*piVar3 + 0x104));
		  System_IO_Directory__Exists(uVar2,0);
		  piVar3 = (int *)func_ii_13967(param2,0);
		  local_c = 0;
		  local_8 = &local_4;
		  local_4 = piVar3;
		  if (DAT_ram_00a54e41 == '\0') {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vi(0x7ff,&System_IO_BinaryWriter_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_00a54e41 = '\x01';
		      goto code_r0x80b25e5f;
		    }
		  }
		  else {
		code_r0x80b25e5f:
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_IO_BinaryWriter_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x12a,uVar2,piVar3,0);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (*(undefined4 *)(*param1 + 0x1a0),param1,uVar2,*(undefined4 *)(*param1 + 0x1a4));
		        if (DAT_ram_009d3e38 != 1) goto code_r0x80b25f58;
		      }
		    }
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar6 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar4) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar6 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar6;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		code_r0x80b25f58:
		      piVar3 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar4 = *local_4;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		              puVar5 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80b25fd0;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar5 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80b25fd0:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar3,puVar5[1]);
		      }
		      if (iVar6 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 299,&local_c);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06007823 RID: 30755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007823")]
		[Address(RVA = "0xC177", Offset = "0xC177", VA = "0xC177")]
		public void SaveToFile(string aFileName)
		{
		/* --- GHIDRA: SaveToFile ---
		undefined4 I2_Loc_SimpleJSON_JSONNode__SaveToFile(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  int iVar4;
		  uint *puVar5;
		  int iVar6;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  iVar6 = 0;
		  if (DAT_ram_00a54e43 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Convert_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IO_MemoryStream_TypeInfo);
		    DAT_ram_00a54e43 = '\x01';
		  }
		  piVar2 = (int *)unnamed_function_1417(System_IO_MemoryStream_TypeInfo);
		  ICSharpCode_SharpZipLib_Zip_ZipException___ctor(piVar2,0);
		  local_c = 0;
		  local_8 = &local_4;
		  local_4 = piVar2;
		  if (DAT_ram_00a54e41 == '\0') {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vi(0x7ff,&System_IO_BinaryWriter_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_00a54e41 = '\x01';
		      goto code_r0x80b260f5;
		    }
		code_r0x80b262a8:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		code_r0x80b260f5:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_IO_BinaryWriter_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80b262a8;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x12a,uVar3,piVar2,0)
		    ;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80b262a8;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(*param1 + 0x1a0),param1,uVar3,*(undefined4 *)(*param1 + 0x1a4));
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80b262a8;
		    DAT_ram_009d3e38 = 0;
		    unnamed_function_184058
		              (*(undefined4 *)(*local_4 + 0x128),local_4,0,*(undefined4 *)(*local_4 + 300));
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::invoke_iii
		                        (*(undefined4 *)(*local_4 + 0x218),local_4,*(undefined4 *)(*local_4 + 0x21c)
		                        );
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80b262bc:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		        if (*(int *)(System_Convert_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,System_Convert_TypeInfo
		                    );
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80b262bc;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x187,uVar3,0);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 != 1) goto code_r0x80b26311;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		    }
		  }
		  iVar6 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar4) {
		    piVar2 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar6 = *piVar2;
		    uVar3 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar6;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		code_r0x80b26311:
		      piVar2 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar4 = *local_4;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		              puVar5 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80b26389;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar5 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80b26389:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar2,puVar5[1]);
		      }
		      if (iVar6 == 0) {
		        return uVar3;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 300,&local_c);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
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
		}
		*/

		}

		// Token: 0x06007824 RID: 30756 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007824")]
		[Address(RVA = "0xC178", Offset = "0xC178", VA = "0xC178")]
		public string SaveToBase64()
		{
		/* --- GHIDRA: SaveToBase64 ---
		undefined4 I2_Loc_SimpleJSON_JSONNode__SaveToBase64(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  uVar1 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  uVar2 = unnamed_function_2232(&StringLiteral_4665);
		  System_String__Concat(uVar1,uVar2,0);
		  uVar2 = unnamed_function_2232(&Method_I2_Loc_SimpleJSON_JSONNode_LoadFromCompressedFile__);
		  func_ii_1050(uVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06007825 RID: 30757 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007825")]
		[Address(RVA = "0x18F5", Offset = "0x18F5", VA = "0x18F5")]
		public static JSONNode Deserialize(BinaryReader aReader)
		{
			return null;
		}

		// Token: 0x06007826 RID: 30758 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007826")]
		[Address(RVA = "0xC179", Offset = "0xC179", VA = "0xC179")]
		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
		/* --- GHIDRA: LoadFromCompressedFile ---
		undefined4 I2_Loc_SimpleJSON_JSONNode__LoadFromCompressedFile(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  uVar1 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  uVar2 = unnamed_function_2232(&StringLiteral_4665);
		  System_String__Concat(uVar1,uVar2,0);
		  uVar2 = unnamed_function_2232(&Method_I2_Loc_SimpleJSON_JSONNode_LoadFromCompressedStream__);
		  func_ii_1050(uVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06007827 RID: 30759 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007827")]
		[Address(RVA = "0xC17A", Offset = "0xC17A", VA = "0xC17A")]
		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
		/* --- GHIDRA: LoadFromCompressedStream ---
		undefined4 I2_Loc_SimpleJSON_JSONNode__LoadFromCompressedStream(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  uVar1 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  uVar2 = unnamed_function_2232(&StringLiteral_4665);
		  System_String__Concat(uVar1,uVar2,0);
		  uVar2 = unnamed_function_2232(&Method_I2_Loc_SimpleJSON_JSONNode_LoadFromCompressedBase64__);
		  func_ii_1050(uVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06007828 RID: 30760 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007828")]
		[Address(RVA = "0xC17B", Offset = "0xC17B", VA = "0xC17B")]
		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
		/* --- GHIDRA: LoadFromCompressedBase64 ---
		undefined4 I2_Loc_SimpleJSON_JSONNode__LoadFromCompressedBase64(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  uint *puVar4;
		  int iVar5;
		  int iVar6;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a54e46 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    DAT_ram_00a54e46 = '\x01';
		  }
		  local_4 = (int *)Core_Files_AbstractFileManager__TryLoad(param1,0);
		  DAT_ram_009d3e38 = 0;
		  local_c = 0;
		  local_8 = &local_4;
		  uVar2 = import::env::invoke_iii
		                    (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x12f,local_4,local_4);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    iVar5 = global_1;
		    iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar5 == iVar6) {
		      piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		      iVar5 = *piVar3;
		      uVar2 = 0;
		      DAT_ram_009d3e38 = 0;
		      local_c = iVar5;
		      import::env::invoke_v(0x123);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 != 1) goto code_r0x80b26aa8;
		      uVar2 = import::env::__cxa_find_matching_catch_2();
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x130,&local_c);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    import::env::__resumeException(uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x80b26aa8:
		  piVar3 = local_4;
		  DAT_ram_009d3e38 = 0;
		  if (local_4 != (int *)0x0) {
		    uVar1 = 0;
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80b26b20;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80b26b20:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar3,puVar4[1]);
		  }
		  if (iVar5 == 0) {
		    return uVar2;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06007829 RID: 30761 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007829")]
		[Address(RVA = "0x18F7", Offset = "0x18F7", VA = "0x18F7")]
		public static JSONNode LoadFromStream(Stream aData)
		{
			return null;
		}

		// Token: 0x0600782A RID: 30762 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600782A")]
		[Address(RVA = "0xC17C", Offset = "0xC17C", VA = "0xC17C")]
		public static JSONNode LoadFromFile(string aFileName)
		{
		/* --- GHIDRA: LoadFromFile ---
		undefined4 I2_Loc_SimpleJSON_JSONNode__LoadFromFile(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a54e47 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Convert_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IO_MemoryStream_TypeInfo);
		    DAT_ram_00a54e47 = '\x01';
		  }
		  if (*(int *)(System_Convert_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Convert_TypeInfo);
		  }
		  uVar1 = System_Xml_XmlConvert__FromBinHexString(param1,0);
		  param1_00 = (int *)unnamed_function_1417(System_IO_MemoryStream_TypeInfo);
		  Pathfinding_Ionic_Zlib_ZlibStream___ctor(param1_00,uVar1,0);
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x128) * 4))
		            (param1_00,0,*(undefined4 *)(*param1_00 + 300));
		  uVar1 = func_ii_6390(param1_00,param1_00);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600782B RID: 30763 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600782B")]
		[Address(RVA = "0xC17D", Offset = "0xC17D", VA = "0xC17D")]
		public static JSONNode LoadFromBase64(string aBase64)
		{
			return null;
		}

		// Token: 0x0600782C RID: 30764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600782C")]
		[Address(RVA = "0xC17E", Offset = "0xC17E", VA = "0xC17E")]
		public JSONNode()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Item ---
		undefined4 I2_Loc_SimpleJSON_JSONNode__set_Item(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a54e34 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a54e34 = '\x01';
		  }
		  return StringLiteral_5;
		}
		*/


		/* --- GHIDRA: set_Item ---
		undefined4 I2_Loc_SimpleJSON_JSONNode__set_Item(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a54e34 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a54e34 = '\x01';
		  }
		  return StringLiteral_5;
		}
		*/


		/* --- GHIDRA: get_Count ---
		void I2_Loc_SimpleJSON_JSONNode__get_Count(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a54e35 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a54e35 = '\x01';
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		            (param1,StringLiteral_5,param2,*(undefined4 *)(*param1 + 0xe4));
		  return;
		}
		*/


		/* --- GHIDRA: get_Childs ---
		int I2_Loc_SimpleJSON_JSONNode__get_Childs(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a54e37 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONNode__get_DeepChilds_d__19_TypeInfo);
		    DAT_ram_00a54e37 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(I2_Loc_SimpleJSON_JSONNode__get_DeepChilds_d__19_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = 0xfffffffe;
		  uVar2 = func_ii_6393(0);
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  return iVar1;
		}
		*/


		/* --- GHIDRA: get_DeepChilds ---
		undefined4 I2_Loc_SimpleJSON_JSONNode__get_DeepChilds(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a54e38 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_10069);
		    DAT_ram_00a54e38 = '\x01';
		  }
		  return StringLiteral_10069;
		}
		*/


		/* --- GHIDRA: get_AsInt ---
		void I2_Loc_SimpleJSON_JSONNode__get_AsInt(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 local_4;
		  
		  local_4 = param2;
		  uVar1 = func_ii_4443(&local_4,0);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		            (param1,uVar1,*(undefined4 *)(*param1 + 0x114));
		  return;
		}
		*/


		/* --- GHIDRA: set_AsInt ---
		float I2_Loc_SimpleJSON_JSONNode__set_AsInt(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  float4 local_4;
		  
		  local_4 = 0.0;
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x108) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x10c));
		  iVar1 = System_Text_RegularExpressions_Capture__get_Value(param1_00,&local_4,0);
		  if (iVar1 == 0) {
		    local_4 = 0.0;
		  }
		  return (float)local_4;
		}
		*/


		/* --- GHIDRA: get_AsFloat ---
		void I2_Loc_SimpleJSON_JSONNode__get_AsFloat(int *param1,float param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  float4 local_4;
		  
		  local_4 = (float4)param2;
		  uVar1 = System_Collections_Generic_List_float___GetEnumerator(&local_4,0);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		            (param1,uVar1,*(undefined4 *)(*param1 + 0x114));
		  return;
		}
		*/


		/* --- GHIDRA: set_AsFloat ---
		double I2_Loc_SimpleJSON_JSONNode__set_AsFloat(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  float8 local_8;
		  
		  local_8 = 0.0;
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x108) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x10c));
		  iVar1 = System_Double__Parse(param1_00,&local_8,0);
		  if (iVar1 == 0) {
		    local_8 = 0.0;
		  }
		  return (double)local_8;
		}
		*/


		/* --- GHIDRA: get_AsDouble ---
		void I2_Loc_SimpleJSON_JSONNode__get_AsDouble(int *param1,double param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  float8 local_8;
		  
		  local_8 = (float8)param2;
		  uVar1 = func_ii_7515(&local_8,0);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		            (param1,uVar1,*(undefined4 *)(*param1 + 0x114));
		  return;
		}
		*/


		/* --- GHIDRA: set_AsDouble ---
		uint I2_Loc_SimpleJSON_JSONNode__set_AsDouble(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  uint uVar3;
		  byte local_1;
		  
		  local_1 = 0;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x108) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x10c));
		  if (*(int *)(DAT_ram_00a66944 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a66944);
		  }
		  iVar2 = Unity_Services_LevelPlay_LevelPlayAdInfo__GetAdSize(uVar1,&local_1,0);
		  if (iVar2 == 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x108) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x10c));
		    uVar3 = func_ii_4769(uVar1,0);
		    uVar3 = uVar3 ^ 1;
		  }
		  else {
		    uVar3 = (uint)(local_1 != 0);
		  }
		  return uVar3;
		}
		*/


		/* --- GHIDRA: get_AsBool ---
		void I2_Loc_SimpleJSON_JSONNode__get_AsBool(int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  
		  if (DAT_ram_00a54e3a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_23131);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27872);
		    DAT_ram_00a54e3a = '\x01';
		  }
		  puVar1 = &StringLiteral_27872;
		  if (param2 == 0) {
		    puVar1 = &StringLiteral_23131;
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		            (param1,*puVar1,*(undefined4 *)(*param1 + 0x114));
		  return;
		}
		*/


		/* --- GHIDRA: set_AsBool ---
		int * I2_Loc_SimpleJSON_JSONNode__set_AsBool(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  piVar1 = (int *)0x0;
		  if (DAT_ram_00a54e3b == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONArray_TypeInfo);
		    DAT_ram_00a54e3b = '\x01';
		  }
		  if (param1 != (int *)0x0) {
		    if (((uint)*(byte *)(I2_Loc_SimpleJSON_JSONArray_TypeInfo + 0xb8) <=
		         (uint)*(byte *)(*param1 + 0xb8)) &&
		       (piVar1 = param1,
		       *(int *)(*(int *)(*param1 + 100) +
		                (uint)*(byte *)(I2_Loc_SimpleJSON_JSONArray_TypeInfo + 0xb8) * 4 + -4) !=
		       I2_Loc_SimpleJSON_JSONArray_TypeInfo)) {
		      piVar1 = (int *)0x0;
		    }
		  }
		  return piVar1;
		}
		*/


		/* --- GHIDRA: get_AsArray ---
		int * I2_Loc_SimpleJSON_JSONNode__get_AsArray(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  piVar1 = (int *)0x0;
		  if (DAT_ram_00a54e3c == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONClass_TypeInfo);
		    DAT_ram_00a54e3c = '\x01';
		  }
		  if (param1 != (int *)0x0) {
		    if (((uint)*(byte *)(I2_Loc_SimpleJSON_JSONClass_TypeInfo + 0xb8) <=
		         (uint)*(byte *)(*param1 + 0xb8)) &&
		       (piVar1 = param1,
		       *(int *)(*(int *)(*param1 + 100) +
		                (uint)*(byte *)(I2_Loc_SimpleJSON_JSONClass_TypeInfo + 0xb8) * 4 + -4) !=
		       I2_Loc_SimpleJSON_JSONClass_TypeInfo)) {
		      piVar1 = (int *)0x0;
		    }
		  }
		  return piVar1;
		}
		*/


		/* --- GHIDRA: get_AsObject ---
		int I2_Loc_SimpleJSON_JSONNode__get_AsObject(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a54e3d == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONData_TypeInfo);
		    DAT_ram_00a54e3d = '\x01';
		  }
		  iVar1 = unnamed_function_1417(I2_Loc_SimpleJSON_JSONData_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param1;
		  return iVar1;
		}
		*/


		/* --- GHIDRA: op_Implicit ---
		uint I2_Loc_SimpleJSON_JSONNode__op_Implicit(int *param1,int *param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a54e3e == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONLazyCreator_TypeInfo);
		    DAT_ram_00a54e3e = '\x01';
		  }
		  if ((param2 == (int *)0x0) && (param1 != (int *)0x0)) {
		    if (((uint)*(byte *)(I2_Loc_SimpleJSON_JSONLazyCreator_TypeInfo + 0xb8) <=
		         (uint)*(byte *)(*param1 + 0xb8)) &&
		       (*(int *)(*(int *)(*param1 + 100) +
		                 (uint)*(byte *)(I2_Loc_SimpleJSON_JSONLazyCreator_TypeInfo + 0xb8) * 4 + -4) ==
		        I2_Loc_SimpleJSON_JSONLazyCreator_TypeInfo)) {
		      return 1;
		    }
		  }
		  return (uint)(param1 == param2);
		}
		*/


		/* --- GHIDRA: op_Implicit ---
		uint I2_Loc_SimpleJSON_JSONNode__op_Implicit(int *param1,int *param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a54e3e == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONLazyCreator_TypeInfo);
		    DAT_ram_00a54e3e = '\x01';
		  }
		  if ((param2 == (int *)0x0) && (param1 != (int *)0x0)) {
		    if (((uint)*(byte *)(I2_Loc_SimpleJSON_JSONLazyCreator_TypeInfo + 0xb8) <=
		         (uint)*(byte *)(*param1 + 0xb8)) &&
		       (*(int *)(*(int *)(*param1 + 100) +
		                 (uint)*(byte *)(I2_Loc_SimpleJSON_JSONLazyCreator_TypeInfo + 0xb8) * 4 + -4) ==
		        I2_Loc_SimpleJSON_JSONLazyCreator_TypeInfo)) {
		      return 1;
		    }
		  }
		  return (uint)(param1 == param2);
		}
		*/


		/* --- GHIDRA: op_Equality ---
		uint I2_Loc_SimpleJSON_JSONNode__op_Equality(int *param1,int *param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a54e3e == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONLazyCreator_TypeInfo);
		    DAT_ram_00a54e3e = '\x01';
		  }
		  if ((param2 == (int *)0x0) && (param1 != (int *)0x0)) {
		    if (((uint)*(byte *)(I2_Loc_SimpleJSON_JSONLazyCreator_TypeInfo + 0xb8) <=
		         (uint)*(byte *)(*param1 + 0xb8)) &&
		       (*(int *)(*(int *)(*param1 + 100) +
		                 (uint)*(byte *)(I2_Loc_SimpleJSON_JSONLazyCreator_TypeInfo + 0xb8) * 4 + -4) ==
		        I2_Loc_SimpleJSON_JSONLazyCreator_TypeInfo)) {
		      return 0;
		    }
		  }
		  return (uint)(param1 != param2);
		}
		*/

}
