using System;
using System.Runtime.CompilerServices;
using CloudsFly.Movement;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x02001313 RID: 4883
	[Token(Token = "0x2001313")]
	[Serializable]
	public abstract class WorldObjectEngineArgs : MonoBehaviour
	{
		// Token: 0x17001762 RID: 5986
		// (get) Token: 0x06007407 RID: 29703 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06007408 RID: 29704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001762")]
		public WorldMovementResolver WorldMovementResolver
		{
			[Token(Token = "0x6007407")]
			[Address(RVA = "0xBDD8", Offset = "0xBDD8", VA = "0xBDD8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007408")]
			[Address(RVA = "0xBDD9", Offset = "0xBDD9", VA = "0xBDD9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06007409 RID: 29705
		[Token(Token = "0x6007409")]
		public abstract IWorldObjectEngine GetEngine();

		// Token: 0x0600740A RID: 29706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600740A")]
		[Address(RVA = "0xBDDA", Offset = "0xBDDA", VA = "0xBDDA")]
		protected WorldObjectEngineArgs()
		{
		/* --- GHIDRA: .ctor ---
		void CloudsFly_WorldObjectEngineArgs___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  int iVar3;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5969a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Tween__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Tween__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Tween__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Tween__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Tween__GetEnumerator__);
		    DAT_ram_00a5969a = '\x01';
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
		      goto code_r0x8104aa57;
		    }
		    if (iVar1 == 0) goto code_r0x8104aaad;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x34d,local_8._4_4_,0,0);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar3 != 1);
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8104aa57:
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
		code_r0x8104aaad:
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
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x34e,&local_18);
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

		// Token: 0x04003CC3 RID: 15555
		[Token(Token = "0x4003CC3")]
		[FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Camera camera;

		// Token: 0x04003CC4 RID: 15556
		[Token(Token = "0x4003CC4")]
		[FieldOffset(Offset = "0x14")]
		[HideInInspector]
		public float cloudDistance;

		// Token: 0x04003CC5 RID: 15557
		[Token(Token = "0x4003CC5")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public int chunkSize;

		// Token: 0x04003CC6 RID: 15558
		[Token(Token = "0x4003CC6")]
		[FieldOffset(Offset = "0x1C")]
		[HideInInspector]
		public float widthCamera;

		// Token: 0x04003CC7 RID: 15559
		[Token(Token = "0x4003CC7")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public Vector3 startCameraPosition;

		// Token: 0x04003CC8 RID: 15560
		[Token(Token = "0x4003CC8")]
		[FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		public Func<float, float, float, float> getRandomRange;

		// Token: 0x04003CC9 RID: 15561
		[Token(Token = "0x4003CC9")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public Func<float, float> getRandom;

		// Token: 0x04003CCA RID: 15562
		[Token(Token = "0x4003CCA")]
		[FieldOffset(Offset = "0x34")]
		[HideInInspector]
		public Func<bool> getBlockResetPositions;

		// Token: 0x04003CCB RID: 15563
		[Token(Token = "0x4003CCB")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public Action<bool> setBlockResetPositions;

		// Token: 0x04003CCC RID: 15564
		[Token(Token = "0x4003CCC")]
		[FieldOffset(Offset = "0x3C")]
		[HideInInspector]
		public Action resetPositions;
	}
}
