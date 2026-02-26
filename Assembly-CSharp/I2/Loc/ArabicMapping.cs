using System;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x020013AD RID: 5037
	[Token(Token = "0x20013AD")]
	internal class ArabicMapping
	{
		// Token: 0x060077CE RID: 30670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077CE")]
		[Address(RVA = "0xC129", Offset = "0xC129", VA = "0xC129")]
		public ArabicMapping(int from, int to)
		{
		/* --- GHIDRA: .ctor ---
		void I2_Loc_ArabicMapping___ctor(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int iVar3;
		  uint uVar4;
		  
		  if (DAT_ram_00a54e19 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_ArabicMapping_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_ArabicTable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArabicMapping__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArabicMapping___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ArabicMapping__TypeInfo);
		    DAT_ram_00a54e19 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_ArabicMapping__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_ArabicMapping___ctor__);
		  **(undefined4 **)(I2_Loc_ArabicTable_TypeInfo + 0x5c) = param1_00;
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfe8000000621;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfe8d00000627;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfe8300000623;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfe8500000624;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfe8700000625;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfbfc00000649;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfe8900000626;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfe8f00000628;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfe950000062a;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfe990000062b;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfe9d0000062c;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfea10000062d;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfea50000062e;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfea90000062f;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfeab00000630;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfead00000631;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfeaf00000632;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfeb100000633;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfeb500000634;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfeb900000635;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfebd00000636;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfec100000637;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfec500000638;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfec900000639;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfecd0000063a;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfed100000641;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfed500000642;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfed900000643;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfedd00000644;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfee100000645;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfee500000646;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfee900000647;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfeed00000648;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfef10000064a;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfe8100000622;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfe9300000629;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfb560000067e;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfb7a00000686;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfb8a00000698;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfb92000006af;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = **(int **)(I2_Loc_ArabicTable_TypeInfo + 0x5c);
		  iVar2 = unnamed_function_1417(I2_Loc_ArabicMapping_TypeInfo);
		  *(undefined8 *)(iVar2 + 8) = 0xfb8e000006a9;
		  iVar1 = Method_System_Collections_Generic_List_ArabicMapping__Add__;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = iVar2;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (iVar3,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/

		}

		// Token: 0x04003ED9 RID: 16089
		[Token(Token = "0x4003ED9")]
		[FieldOffset(Offset = "0x8")]
		public int from;

		// Token: 0x04003EDA RID: 16090
		[Token(Token = "0x4003EDA")]
		[FieldOffset(Offset = "0xC")]
		public int to;
	}
}
