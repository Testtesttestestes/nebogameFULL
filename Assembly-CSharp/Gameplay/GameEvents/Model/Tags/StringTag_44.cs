using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007B3 RID: 1971
	[Token(Token = "0x20007B3")]
	public class StringTag_44 : AbstractTag
	{
		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06002EA1 RID: 11937 RVA: 0x00009510 File Offset: 0x00007710
		[Token(Token = "0x1700090F")]
		public int IndexInStringParams
		{
			[Token(Token = "0x6002EA1")]
			[Address(RVA = "0x7F1C", Offset = "0x7F1C", VA = "0x7F1C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002EA2 RID: 11938 RVA: 0x00009528 File Offset: 0x00007728
		[Token(Token = "0x6002EA2")]
		[Address(RVA = "0x7F1D", Offset = "0x7F1D", VA = "0x7F1D", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002EA3 RID: 11939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EA3")]
		[Address(RVA = "0x7F1E", Offset = "0x7F1E", VA = "0x7F1E")]
		public StringTag_44()
		{
		/* --- GHIDRA: .ctor ---
		undefined8 Gameplay_GameEvents_Model_Tags_StringTag_44___ctor(int param1,undefined4 param2)
		
		{
		  double dVar1;
		  
		  dVar1 = *(double *)(*(int *)(param1 + 0x14) + 0x10);
		  if (9.223372036854776e+18 <= ABS(dVar1)) {
		    return 0x8000000000000000;
		  }
		  return (longlong)dVar1;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_IndexInStringParams ---
		int Gameplay_GameEvents_Model_Tags_StringTag_44__get_IndexInStringParams
		              (int *param1,undefined4 param2,int param3,undefined4 *param4,undefined4 param5,
		              undefined4 param6)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 param3_00;
		  int iVar4;
		  double dVar5;
		  int iVar6;
		  undefined4 local_8;
		  int local_4;
		  
		  if (DAT_ram_00a574e5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_string__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_string__get_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7419);
		    DAT_ram_00a574e5 = '\x01';
		  }
		  if (DAT_ram_00a574cb == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_11610);
		    DAT_ram_00a574cb = '\x01';
		  }
		  if (DAT_ram_00a574ca == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_string__Contains__);
		    DAT_ram_00a574ca = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar2 = Google_Protobuf_Collections_RepeatedField_object___Clear
		                    (uVar1,param2,
		                     Method_Google_Protobuf_Collections_RepeatedField_string__Contains__);
		  if (iVar2 == 0) {
		    *param4 = 0;
		  }
		  else {
		    uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_11610,param2,0);
		    *param4 = uVar1;
		    iVar4 = param1[5];
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xec));
		    dVar5 = *(double *)(iVar4 + iVar3 * 8 + 8);
		    if (ABS(dVar5) < 2147483648.0) {
		      iVar3 = (int)dVar5;
		    }
		    else {
		      iVar3 = -0x80000000;
		    }
		    if (-1 < iVar3 + -1) {
		      iVar4 = param1[5];
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xec));
		      dVar5 = *(double *)(iVar4 + iVar3 * 8 + 8);
		      if (ABS(dVar5) < 2147483648.0) {
		        iVar3 = (int)dVar5;
		      }
		      else {
		        iVar3 = -0x80000000;
		      }
		      iVar4 = *(int *)(*(int *)(param3 + 0x24) + 0x38);
		      if (iVar3 + -1 < *(int *)(iVar4 + 0xc)) {
		        iVar6 = param1[5];
		        iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xec));
		        dVar5 = *(double *)(iVar6 + iVar3 * 8 + 8);
		        if (ABS(dVar5) < 2147483648.0) {
		          iVar3 = (int)dVar5;
		        }
		        else {
		          iVar3 = -0x80000000;
		        }
		        uVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (iVar4,iVar3 + -1,
		                           Method_Google_Protobuf_Collections_RepeatedField_string__get_Item__);
		        *param4 = uVar1;
		        return iVar2;
		      }
		    }
		    iVar4 = param1[5];
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xec));
		    dVar5 = *(double *)(iVar4 + iVar3 * 8 + 8);
		    if (ABS(dVar5) < 2147483648.0) {
		      local_4 = (int)dVar5;
		    }
		    else {
		      local_4 = -0x80000000;
		    }
		    local_4 = local_4 + -1;
		    uVar1 = func_ii_1081(DAT_ram_00a66954,&local_4);
		    local_8 = *(undefined4 *)(*(int *)(*(int *)(param3 + 0x24) + 0x38) + 0xc);
		    param3_00 = func_ii_1081(DAT_ram_00a66954,&local_8);
		    uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_7419,uVar1,param3_00,0);
		    *param4 = uVar1;
		  }
		  return iVar2;
		}
		*/

}
