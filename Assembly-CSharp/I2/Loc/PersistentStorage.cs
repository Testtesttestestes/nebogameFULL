using System;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x02001350 RID: 4944
	[Token(Token = "0x2001350")]
	public static class PersistentStorage
	{
		// Token: 0x06007568 RID: 30056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007568")]
		[Address(RVA = "0x3601", Offset = "0x3601", VA = "0x3601")]
		public static void SetSetting_String(string key, string value)
		{
		/* --- GHIDRA: SetSetting_String ---
		void I2_Loc_PersistentStorage__SetSetting_String(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  
		  if (DAT_ram_00a59718 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_I2CustomPersistentStorage_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_PersistentStorage_TypeInfo);
		    DAT_ram_00a59718 = '\x01';
		  }
		  piVar2 = (int *)**(int **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c);
		  if (piVar2 == (int *)0x0) {
		    uVar1 = unnamed_function_1417(I2_Loc_I2CustomPersistentStorage_TypeInfo);
		    **(undefined4 **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c) = uVar1;
		    piVar2 = (int *)**(int **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c);
		  }
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xf8) * 4))(piVar2,*(undefined4 *)(*piVar2 + 0xfc));
		  return;
		}
		*/

		}

		// Token: 0x06007569 RID: 30057 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007569")]
		[Address(RVA = "0xBEFC", Offset = "0xBEFC", VA = "0xBEFC")]
		public static string GetSetting_String(string key, string defaultValue)
		{
		/* --- GHIDRA: GetSetting_String ---
		void I2_Loc_PersistentStorage__GetSetting_String(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  
		  if (DAT_ram_00a59716 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_I2CustomPersistentStorage_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_PersistentStorage_TypeInfo);
		    DAT_ram_00a59716 = '\x01';
		  }
		  piVar2 = (int *)**(int **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c);
		  if (piVar2 == (int *)0x0) {
		    uVar1 = unnamed_function_1417(I2_Loc_I2CustomPersistentStorage_TypeInfo);
		    **(undefined4 **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c) = uVar1;
		    piVar2 = (int *)**(int **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c);
		  }
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xf0) * 4))
		            (piVar2,param1,*(undefined4 *)(*piVar2 + 0xf4));
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600756A RID: 30058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600756A")]
		[Address(RVA = "0xBEFD", Offset = "0xBEFD", VA = "0xBEFD")]
		public static void DeleteSetting(string key)
		{
		/* --- GHIDRA: DeleteSetting ---
		undefined4 I2_Loc_PersistentStorage__DeleteSetting(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  
		  if (DAT_ram_00a59717 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_I2CustomPersistentStorage_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_PersistentStorage_TypeInfo);
		    DAT_ram_00a59717 = '\x01';
		  }
		  piVar2 = (int *)**(int **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c);
		  if (piVar2 == (int *)0x0) {
		    uVar1 = unnamed_function_1417(I2_Loc_I2CustomPersistentStorage_TypeInfo);
		    **(undefined4 **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c) = uVar1;
		    piVar2 = (int *)**(int **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c);
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                    (piVar2,param1,*(undefined4 *)(*piVar2 + 0x104));
		  return uVar1;
		}
		*/

		}

		// Token: 0x0600756B RID: 30059 RVA: 0x000151C8 File Offset: 0x000133C8
		[Token(Token = "0x600756B")]
		[Address(RVA = "0xBEFE", Offset = "0xBEFE", VA = "0xBEFE")]
		public static bool HasSetting(string key)
		{
		/* --- GHIDRA: HasSetting ---
		undefined4 I2_Loc_PersistentStorage__HasSetting(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  
		  if (DAT_ram_00a59719 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_I2CustomPersistentStorage_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_PersistentStorage_TypeInfo);
		    DAT_ram_00a59719 = '\x01';
		  }
		  piVar2 = (int *)**(int **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c);
		  if (piVar2 == (int *)0x0) {
		    uVar1 = unnamed_function_1417(I2_Loc_I2CustomPersistentStorage_TypeInfo);
		    **(undefined4 **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c) = uVar1;
		    piVar2 = (int *)**(int **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c);
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x108) * 4))
		                    (piVar2,*(undefined4 *)(*piVar2 + 0x10c));
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600756C RID: 30060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600756C")]
		[Address(RVA = "0x3602", Offset = "0x3602", VA = "0x3602")]
		public static void ForceSaveSettings()
		{
		/* --- GHIDRA: ForceSaveSettings ---
		void I2_Loc_PersistentStorage__ForceSaveSettings(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a60481 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__Object__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__TermData__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__Clear__);
		    DAT_ram_00a60481 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x10);
		  iVar2 = *(int *)(iVar1 + 0xc);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  if (0 < iVar2) {
		    func_ii_2064(*(undefined4 *)(iVar1 + 8),0,iVar2,0);
		  }
		  iVar1 = *(int *)(param1 + 0x24);
		  iVar2 = *(int *)(iVar1 + 0xc);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  if (0 < iVar2) {
		    func_ii_2064(*(undefined4 *)(iVar1 + 8),0,iVar2,0);
		  }
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x18),
		             Method_System_Collections_Generic_Dictionary_string__TermData__Clear__);
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x58),
		             Method_System_Collections_Generic_Dictionary_string__Object__Clear__);
		  return;
		}
		*/

		}

		// Token: 0x0600756D RID: 30061 RVA: 0x000151E0 File Offset: 0x000133E0
		[Token(Token = "0x600756D")]
		[Address(RVA = "0xBEFF", Offset = "0xBEFF", VA = "0xBEFF")]
		public static bool CanAccessFiles()
		{
		/* --- GHIDRA: CanAccessFiles ---
		undefined4
		I2_Loc_PersistentStorage__CanAccessFiles
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  
		  if (DAT_ram_00a5971b == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_I2CustomPersistentStorage_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_PersistentStorage_TypeInfo);
		    DAT_ram_00a5971b = '\x01';
		  }
		  piVar2 = (int *)**(int **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c);
		  if (piVar2 == (int *)0x0) {
		    uVar1 = unnamed_function_1417(I2_Loc_I2CustomPersistentStorage_TypeInfo);
		    **(undefined4 **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c) = uVar1;
		    piVar2 = (int *)**(int **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c);
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x118) * 4))
		                    (piVar2,param1,param2,param3,*(undefined4 *)(*piVar2 + 0x11c));
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600756E RID: 30062 RVA: 0x000151F8 File Offset: 0x000133F8
		[Token(Token = "0x600756E")]
		[Address(RVA = "0x3600", Offset = "0x3600", VA = "0x3600")]
		public static bool SaveFile(PersistentStorage.eFileType fileType, string fileName, string data, bool logExceptions = true)
		{
		/* --- GHIDRA: SaveFile ---
		void I2_Loc_PersistentStorage__SaveFile(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  
		  if (DAT_ram_00a59714 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_I2CustomPersistentStorage_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_PersistentStorage_TypeInfo);
		    DAT_ram_00a59714 = '\x01';
		  }
		  piVar2 = (int *)**(int **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c);
		  if (piVar2 == (int *)0x0) {
		    uVar1 = unnamed_function_1417(I2_Loc_I2CustomPersistentStorage_TypeInfo);
		    **(undefined4 **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c) = uVar1;
		    piVar2 = (int *)**(int **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c);
		  }
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xe0) * 4))
		            (piVar2,param1,param2,*(undefined4 *)(*piVar2 + 0xe4));
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600756F RID: 30063 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600756F")]
		[Address(RVA = "0xBF00", Offset = "0xBF00", VA = "0xBF00")]
		public static string LoadFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
		/* --- GHIDRA: LoadFile ---
		undefined4
		I2_Loc_PersistentStorage__LoadFile
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  
		  if (DAT_ram_00a5971c == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_I2CustomPersistentStorage_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_PersistentStorage_TypeInfo);
		    DAT_ram_00a5971c = '\x01';
		  }
		  piVar2 = (int *)**(int **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c);
		  if (piVar2 == (int *)0x0) {
		    uVar1 = unnamed_function_1417(I2_Loc_I2CustomPersistentStorage_TypeInfo);
		    **(undefined4 **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c) = uVar1;
		    piVar2 = (int *)**(int **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c);
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x120) * 4))
		                    (piVar2,param1,param2,param3,*(undefined4 *)(*piVar2 + 0x124));
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06007570 RID: 30064 RVA: 0x00015210 File Offset: 0x00013410
		[Token(Token = "0x6007570")]
		[Address(RVA = "0xBF01", Offset = "0xBF01", VA = "0xBF01")]
		public static bool DeleteFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
		/* --- GHIDRA: DeleteFile ---
		undefined4
		I2_Loc_PersistentStorage__DeleteFile
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  
		  if (DAT_ram_00a5971d == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_I2CustomPersistentStorage_TypeInfo);
		    Mono_Security_ASN1__get_Item(&I2_Loc_PersistentStorage_TypeInfo);
		    DAT_ram_00a5971d = '\x01';
		  }
		  piVar2 = (int *)**(int **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c);
		  if (piVar2 == (int *)0x0) {
		    uVar1 = unnamed_function_1417(I2_Loc_I2CustomPersistentStorage_TypeInfo);
		    **(undefined4 **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c) = uVar1;
		    piVar2 = (int *)**(int **)(I2_Loc_PersistentStorage_TypeInfo + 0x5c);
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x128) * 4))
		                    (piVar2,param1,param2,param3,*(undefined4 *)(*piVar2 + 300));
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06007571 RID: 30065 RVA: 0x00015228 File Offset: 0x00013428
		[Token(Token = "0x6007571")]
		[Address(RVA = "0xBF02", Offset = "0xBF02", VA = "0xBF02")]
		public static bool HasFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
		/* --- GHIDRA: HasFile ---
		void I2_Loc_PersistentStorage__HasFile
		               (undefined4 param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param3_00;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  undefined4 *param2_00;
		  int iVar5;
		  int iVar6;
		  char *param4_00;
		  char *pcVar7;
		  int local_8;
		  int local_4;
		  
		  if (DAT_ram_00a5971e == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_18903);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18843);
		    DAT_ram_00a5971e = '\x01';
		  }
		  local_4 = 0;
		  iVar5 = *(int *)(param3 + 8);
		  if (iVar5 < 0x1f41) {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x34f,param2,param3,0);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else if (DAT_ram_00a63a16 == '\0') {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vi(0x7ff,&System_Math_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_00a63a16 = '\x01';
		      goto code_r0x81051be7;
		    }
		code_r0x81051e27:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		code_r0x81051be7:
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,System_Math_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81051e27;
		    }
		    if (ABS(CEIL((float)iVar5 / 8000.0)) < 2.1474836e+09) {
		      iVar6 = (int)CEIL((float)iVar5 / 8000.0);
		    }
		    else {
		      iVar6 = -0x80000000;
		    }
		    iVar2 = 0;
		    local_4 = iVar6;
		    if (0 < iVar6) {
		      do {
		        DAT_ram_009d3e38 = 0;
		        local_8 = iVar2;
		        uVar3 = import::env::invoke_iii
		                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,DAT_ram_00a66954,
		                           &local_8);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81051e39;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iiiii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x261,
		                           StringLiteral_18903,uVar3,param2,0);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81051e39;
		        }
		        DAT_ram_009d3e38 = 0;
		        pcVar7 = (char *)(iVar5 + iVar2 * -8000);
		        param4_00 = s_struct_Uniforms___color__array<v_ram_00001f04 + 0x3c;
		        if ((int)pcVar7 < 8000) {
		          param4_00 = pcVar7;
		        }
		        param3_00 = import::env::invoke_iiiii
		                              (s_struct_Uniforms___color__array<v_ram_000013c7 + 0xc1,param3,
		                               iVar2 * 8000,param4_00,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x81051e1d:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81051e39;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x34f,uVar3,param3_00,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x81051e1d;
		        iVar2 = iVar2 + 1;
		      } while (iVar2 < iVar6);
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x1d8,&local_4,0);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::invoke_iiii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1e4,StringLiteral_18843
		                         ,uVar3,0);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x34f,param2,uVar3,0);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          return;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		  }
		code_r0x81051e39:
		  iVar5 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 == iVar6) {
		    puVar4 = (undefined4 *)import::env::__cxa_begin_catch(uVar3);
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar3,
		                         *(undefined4 *)*puVar4);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 != 1) {
		        if (iVar6 != 0) {
		          import::env::__cxa_end_catch();
		          uVar3 = unnamed_function_2232(&StringLiteral_7467);
		          uVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar3,param2,0);
		          iVar5 = unnamed_function_2232(&OKG_Logs_Debug_TypeInfo);
		          if (*(int *)(iVar5 + 0x74) == 0) {
		            func_ii_306000(iVar5);
		          }
		          func_ii_7109(uVar3,0);
		          return;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar4;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81051f74;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x81051f74:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x04003D57 RID: 15703
		[Token(Token = "0x4003D57")]
		[FieldOffset(Offset = "0x0")]
		private static I2CustomPersistentStorage mStorage;

		// Token: 0x02001351 RID: 4945
		[Token(Token = "0x2001351")]
		public enum eFileType
		{
			// Token: 0x04003D59 RID: 15705
			[Token(Token = "0x4003D59")]
			Raw,
			// Token: 0x04003D5A RID: 15706
			[Token(Token = "0x4003D5A")]
			Persistent,
			// Token: 0x04003D5B RID: 15707
			[Token(Token = "0x4003D5B")]
			Temporal,
			// Token: 0x04003D5C RID: 15708
			[Token(Token = "0x4003D5C")]
			Streaming
		}
	}
}
