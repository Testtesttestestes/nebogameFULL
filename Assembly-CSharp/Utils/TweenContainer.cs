using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;

namespace Utils
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	public class TweenContainer : IDisposable
	{
		// Token: 0x060002F7 RID: 759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x576E", Offset = "0x576E", VA = "0x576E")]
		public void AddTween(Tween tween)
		{
		/* --- GHIDRA: AddTween ---
		void Utils_TweenContainer__AddTween(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  int iVar3;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a6282a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Tween__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Tween__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Tween__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Tween__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Tween__GetEnumerator__);
		    DAT_ram_00a6282a = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 8),
		             Method_System_Collections_Generic_List_Tween__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_Tween__MoveNext__);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x820f6c11;
		    }
		    if (iVar1 == 0) goto code_r0x820f6c67;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x34d,local_8._4_4_,0,0);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar3 != 1);
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x820f6c11:
		  iVar3 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar3 == iVar1) {
		    piVar2 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar1 = *piVar2;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar1;
		    import::env::invoke_v(0x123);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 != 1) {
		      if (iVar1 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x820f6c67:
		      DAT_ram_009d3e38 = 0;
		      iVar3 = *(int *)(param1 + 8);
		      iVar1 = *(int *)(iVar3 + 0xc);
		      *(undefined4 *)(iVar3 + 0xc) = 0;
		      *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		      if (0 < iVar1) {
		        func_ii_2064(*(undefined4 *)(iVar3 + 8),0,iVar1,0);
		      }
		      return;
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Raycas_ram_00004083 + 0x1c,&local_18);
		  iVar3 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar3 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(param1_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x576F", Offset = "0x576F", VA = "0x576F")]
		public void StopAllTweens()
		{
		/* --- GHIDRA: StopAllTweens ---
		void Utils_TweenContainer__StopAllTweens(undefined4 param1,undefined4 param2)
		
		{
		  Utils_TweenContainer__AddTween(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x5770", Offset = "0x5770", VA = "0x5770", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Utils_TweenContainer__Dispose(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a6282b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Tween___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_Tween__TypeInfo);
		    DAT_ram_00a6282b = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_Tween__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (param1_00,4,Method_System_Collections_Generic_List_Tween___ctor__);
		  *(undefined4 *)(param1 + 8) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x060002FA RID: 762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x5771", Offset = "0x5771", VA = "0x5771")]
		public TweenContainer()
		{
		/* --- GHIDRA: .ctor ---
		void Utils_TweenContainer___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a6282c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    DAT_ram_00a6282c = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		  func_ii_2101(param1_00,0);
		  *(undefined4 *)(param1 + 8) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x8")]
		private readonly List<Tween> _tweens;
	}
}
