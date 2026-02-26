using System;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x020013AF RID: 5039
	[Token(Token = "0x20013AF")]
	internal class TashkeelLocation
	{
		// Token: 0x060077D2 RID: 30674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077D2")]
		[Address(RVA = "0xC12D", Offset = "0xC12D", VA = "0xC12D")]
		public TashkeelLocation(char tashkeel, int position)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 I2_Loc_TashkeelLocation___ctor(undefined4 param1,int *param2,undefined4 param3)
		
		{
		  short sVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 uVar7;
		  int iVar8;
		  uint uVar9;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a54e1c == '\0') {
		    Mono_Security_ASN1__get_Item(&char___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TashkeelLocation__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TashkeelLocation___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TashkeelLocation__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_TashkeelLocation__TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_TashkeelLocation_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Field__PrivateImplementationDetails__6B37F2DC3CBC36CB512AAB959CD9F9E3A5ED19A1282D3D8D0EF02E14C2935C71
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a54e1c = '\x01';
		  }
		  iVar4 = unnamed_function_1417(System_Collections_Generic_List_TashkeelLocation__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar4,Method_System_Collections_Generic_List_TashkeelLocation___ctor__);
		  *param2 = iVar4;
		  iVar4 = I2_Loc_StringObfucator__XoREncode(param1,0);
		  if (0 < *(int *)(iVar4 + 0xc)) {
		    iVar2 = 0;
		    do {
		      sVar1 = *(short *)(iVar4 + iVar2 * 2 + 0x10);
		      if (sVar1 == 0x64b) {
		        iVar8 = *param2;
		        iVar5 = unnamed_function_1417(I2_Loc_TashkeelLocation_TypeInfo);
		        *(int *)(iVar5 + 0xc) = iVar2;
		        *(undefined2 *)(iVar5 + 8) = 0x64b;
		        iVar6 = Method_System_Collections_Generic_List_TashkeelLocation__Add__;
		        *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		        uVar9 = *(uint *)(iVar8 + 0xc);
		        if (uVar9 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		          *(uint *)(iVar8 + 0xc) = uVar9 + 1;
		          *(int *)(*(int *)(iVar8 + 8) + uVar9 * 4 + 0x10) = iVar5;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (iVar8,iVar5,*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		        }
		code_r0x80b21227:
		        iVar3 = iVar3 + 1;
		      }
		      else {
		        if (sVar1 == 0x64c) {
		          iVar8 = *param2;
		          iVar5 = unnamed_function_1417(I2_Loc_TashkeelLocation_TypeInfo);
		          *(int *)(iVar5 + 0xc) = iVar2;
		          *(undefined2 *)(iVar5 + 8) = 0x64c;
		          iVar6 = Method_System_Collections_Generic_List_TashkeelLocation__Add__;
		          *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		          uVar9 = *(uint *)(iVar8 + 0xc);
		          if (uVar9 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		            *(uint *)(iVar8 + 0xc) = uVar9 + 1;
		            *(int *)(*(int *)(iVar8 + 8) + uVar9 * 4 + 0x10) = iVar5;
		          }
		          else {
		            System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                      (iVar8,iVar5,*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		          }
		          goto code_r0x80b21227;
		        }
		        if (sVar1 == 0x64d) {
		          iVar8 = *param2;
		          iVar5 = unnamed_function_1417(I2_Loc_TashkeelLocation_TypeInfo);
		          *(int *)(iVar5 + 0xc) = iVar2;
		          *(undefined2 *)(iVar5 + 8) = 0x64d;
		          iVar6 = Method_System_Collections_Generic_List_TashkeelLocation__Add__;
		          *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		          uVar9 = *(uint *)(iVar8 + 0xc);
		          if (uVar9 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		            *(uint *)(iVar8 + 0xc) = uVar9 + 1;
		            *(int *)(*(int *)(iVar8 + 8) + uVar9 * 4 + 0x10) = iVar5;
		          }
		          else {
		            System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                      (iVar8,iVar5,*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		          }
		          goto code_r0x80b21227;
		        }
		        if (sVar1 == 0x64e) {
		          if (0 < iVar3) {
		            iVar6 = System_Linq_Enumerable__ToList_object_
		                              (*param2,iVar3 + -1,
		                               Method_System_Collections_Generic_List_TashkeelLocation__get_Item__);
		            if (*(short *)(iVar6 + 8) == 0x651) {
		              iVar6 = System_Linq_Enumerable__ToList_object_
		                                (*param2,iVar3 + -1,
		                                 Method_System_Collections_Generic_List_TashkeelLocation__get_Item__
		                                );
		              *(undefined2 *)(iVar6 + 8) = 0xfc60;
		              goto code_r0x80b2122f;
		            }
		          }
		          iVar8 = *param2;
		          iVar5 = unnamed_function_1417(I2_Loc_TashkeelLocation_TypeInfo);
		          *(int *)(iVar5 + 0xc) = iVar2;
		          *(undefined2 *)(iVar5 + 8) = 0x64e;
		          iVar6 = Method_System_Collections_Generic_List_TashkeelLocation__Add__;
		          *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		          uVar9 = *(uint *)(iVar8 + 0xc);
		          if (uVar9 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		            *(uint *)(iVar8 + 0xc) = uVar9 + 1;
		            *(int *)(*(int *)(iVar8 + 8) + uVar9 * 4 + 0x10) = iVar5;
		          }
		          else {
		            System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                      (iVar8,iVar5,*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		          }
		          goto code_r0x80b21227;
		        }
		        if (sVar1 == 0x64f) {
		          if (0 < iVar3) {
		            iVar6 = System_Linq_Enumerable__ToList_object_
		                              (*param2,iVar3 + -1,
		                               Method_System_Collections_Generic_List_TashkeelLocation__get_Item__);
		            if (*(short *)(iVar6 + 8) == 0x651) {
		              iVar6 = System_Linq_Enumerable__ToList_object_
		                                (*param2,iVar3 + -1,
		                                 Method_System_Collections_Generic_List_TashkeelLocation__get_Item__
		                                );
		              *(undefined2 *)(iVar6 + 8) = 0xfc61;
		              goto code_r0x80b2122f;
		            }
		          }
		          iVar8 = *param2;
		          iVar5 = unnamed_function_1417(I2_Loc_TashkeelLocation_TypeInfo);
		          *(int *)(iVar5 + 0xc) = iVar2;
		          *(undefined2 *)(iVar5 + 8) = 0x64f;
		          iVar6 = Method_System_Collections_Generic_List_TashkeelLocation__Add__;
		          *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		          uVar9 = *(uint *)(iVar8 + 0xc);
		          if (uVar9 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		            *(uint *)(iVar8 + 0xc) = uVar9 + 1;
		            *(int *)(*(int *)(iVar8 + 8) + uVar9 * 4 + 0x10) = iVar5;
		          }
		          else {
		            System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                      (iVar8,iVar5,*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		          }
		          goto code_r0x80b21227;
		        }
		        if (sVar1 == 0x650) {
		          if (0 < iVar3) {
		            iVar6 = System_Linq_Enumerable__ToList_object_
		                              (*param2,iVar3 + -1,
		                               Method_System_Collections_Generic_List_TashkeelLocation__get_Item__);
		            if (*(short *)(iVar6 + 8) == 0x651) {
		              iVar6 = System_Linq_Enumerable__ToList_object_
		                                (*param2,iVar3 + -1,
		                                 Method_System_Collections_Generic_List_TashkeelLocation__get_Item__
		                                );
		              *(undefined2 *)(iVar6 + 8) = 0xfc62;
		              goto code_r0x80b2122f;
		            }
		          }
		          iVar8 = *param2;
		          iVar5 = unnamed_function_1417(I2_Loc_TashkeelLocation_TypeInfo);
		          *(int *)(iVar5 + 0xc) = iVar2;
		          *(undefined2 *)(iVar5 + 8) = 0x650;
		          iVar6 = Method_System_Collections_Generic_List_TashkeelLocation__Add__;
		          *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		          uVar9 = *(uint *)(iVar8 + 0xc);
		          if (uVar9 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		            *(uint *)(iVar8 + 0xc) = uVar9 + 1;
		            *(int *)(*(int *)(iVar8 + 8) + uVar9 * 4 + 0x10) = iVar5;
		          }
		          else {
		            System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                      (iVar8,iVar5,*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		          }
		          goto code_r0x80b21227;
		        }
		        if (sVar1 != 0x651) {
		          if (sVar1 == 0x652) {
		            iVar8 = *param2;
		            iVar5 = unnamed_function_1417(I2_Loc_TashkeelLocation_TypeInfo);
		            *(int *)(iVar5 + 0xc) = iVar2;
		            *(undefined2 *)(iVar5 + 8) = 0x652;
		            iVar6 = Method_System_Collections_Generic_List_TashkeelLocation__Add__;
		            *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		            uVar9 = *(uint *)(iVar8 + 0xc);
		            if (uVar9 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		              *(uint *)(iVar8 + 0xc) = uVar9 + 1;
		              *(int *)(*(int *)(iVar8 + 8) + uVar9 * 4 + 0x10) = iVar5;
		            }
		            else {
		              System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                        (iVar8,iVar5,*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38)
		                        );
		            }
		          }
		          else {
		            if (sVar1 != 0x653) goto code_r0x80b2122f;
		            iVar8 = *param2;
		            iVar5 = unnamed_function_1417(I2_Loc_TashkeelLocation_TypeInfo);
		            *(int *)(iVar5 + 0xc) = iVar2;
		            *(undefined2 *)(iVar5 + 8) = 0x653;
		            iVar6 = Method_System_Collections_Generic_List_TashkeelLocation__Add__;
		            *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		            uVar9 = *(uint *)(iVar8 + 0xc);
		            if (uVar9 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		              *(uint *)(iVar8 + 0xc) = uVar9 + 1;
		              *(int *)(*(int *)(iVar8 + 8) + uVar9 * 4 + 0x10) = iVar5;
		            }
		            else {
		              System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                        (iVar8,iVar5,*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38)
		                        );
		            }
		          }
		          goto code_r0x80b21227;
		        }
		        if (iVar3 < 1) {
		code_r0x80b210b8:
		          iVar8 = *param2;
		          iVar5 = unnamed_function_1417(I2_Loc_TashkeelLocation_TypeInfo);
		          *(int *)(iVar5 + 0xc) = iVar2;
		          *(undefined2 *)(iVar5 + 8) = 0x651;
		          iVar6 = Method_System_Collections_Generic_List_TashkeelLocation__Add__;
		          *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		          uVar9 = *(uint *)(iVar8 + 0xc);
		          if (uVar9 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		            *(uint *)(iVar8 + 0xc) = uVar9 + 1;
		            *(int *)(*(int *)(iVar8 + 8) + uVar9 * 4 + 0x10) = iVar5;
		          }
		          else {
		            System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                      (iVar8,iVar5,*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		          }
		          goto code_r0x80b21227;
		        }
		        iVar5 = iVar3 + -1;
		        iVar6 = System_Linq_Enumerable__ToList_object_
		                          (*param2,iVar5,
		                           Method_System_Collections_Generic_List_TashkeelLocation__get_Item__);
		        sVar1 = *(short *)(iVar6 + 8);
		        iVar6 = System_Linq_Enumerable__ToList_object_
		                          (*param2,iVar5,
		                           Method_System_Collections_Generic_List_TashkeelLocation__get_Item__);
		        if (sVar1 == 0x64e) {
		          *(undefined2 *)(iVar6 + 8) = 0xfc60;
		        }
		        else {
		          sVar1 = *(short *)(iVar6 + 8);
		          iVar6 = System_Linq_Enumerable__ToList_object_
		                            (*param2,iVar5,
		                             Method_System_Collections_Generic_List_TashkeelLocation__get_Item__);
		          if (sVar1 == 0x64f) {
		            *(undefined2 *)(iVar6 + 8) = 0xfc61;
		          }
		          else {
		            if (*(short *)(iVar6 + 8) != 0x650) goto code_r0x80b210b8;
		            iVar6 = System_Linq_Enumerable__ToList_object_
		                              (*param2,iVar5,
		                               Method_System_Collections_Generic_List_TashkeelLocation__get_Item__);
		            *(undefined2 *)(iVar6 + 8) = 0xfc62;
		          }
		        }
		      }
		code_r0x80b2122f:
		      iVar2 = iVar2 + 1;
		    } while (iVar2 < *(int *)(iVar4 + 0xc));
		  }
		  iVar3 = 0;
		  uVar7 = Mono_Security_ASN1Convert__ToOid(char___TypeInfo,0xc);
		  System_Runtime_CompilerServices_RuntimeHelpers__InitializeArray
		            (uVar7,
		             Field__PrivateImplementationDetails__6B37F2DC3CBC36CB512AAB959CD9F9E3A5ED19A1282D3D8D0EF02E14C2935C71
		             ,0);
		  iVar4 = Facebook_Unity_FBLocation__FromDictionary(param1,uVar7,0);
		  uVar7 = StringLiteral_5;
		  if (0 < *(int *)(iVar4 + 0xc)) {
		    do {
		      uVar7 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor
		                        (uVar7,*(undefined4 *)(iVar4 + iVar3 * 4 + 0x10),0);
		      iVar3 = iVar3 + 1;
		    } while (iVar3 < *(int *)(iVar4 + 0xc));
		  }
		  return uVar7;
		}
		*/

		}

		// Token: 0x04003EDD RID: 16093
		[Token(Token = "0x4003EDD")]
		[FieldOffset(Offset = "0x8")]
		public char tashkeel;

		// Token: 0x04003EDE RID: 16094
		[Token(Token = "0x4003EDE")]
		[FieldOffset(Offset = "0xC")]
		public int position;
	}
}
