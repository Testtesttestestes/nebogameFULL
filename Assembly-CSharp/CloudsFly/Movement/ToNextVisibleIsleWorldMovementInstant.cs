using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly.Movement
{
	// Token: 0x02001327 RID: 4903
	[Token(Token = "0x2001327")]
	public class ToNextVisibleIsleWorldMovementInstant : AbstractWorldMovement
	{
		// Token: 0x1700176F RID: 5999
		// (get) Token: 0x06007448 RID: 29768 RVA: 0x00014EE0 File Offset: 0x000130E0
		[Token(Token = "0x1700176F")]
		public override WorldMovementTypes Type
		{
			[Token(Token = "0x6007448")]
			[Address(RVA = "0xBE16", Offset = "0xBE16", VA = "0xBE16", Slot = "5")]
			get
			{
				return (WorldMovementTypes)0;
			}
		}

		// Token: 0x06007449 RID: 29769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007449")]
		[Address(RVA = "0xBE17", Offset = "0xBE17", VA = "0xBE17", Slot = "6")]
		public override void Move(Vector3 target, Camera camera, Action callback)
		{
		/* --- GHIDRA: Move ---
		void CloudsFly_Movement_ToNextVisibleIsleWorldMovementInstant__Move(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5969c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Tween___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_Tween__TypeInfo);
		    DAT_ram_00a5969c = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_Tween__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_Tween___ctor__);
		  *(undefined4 *)(param1 + 8) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x0600744A RID: 29770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600744A")]
		[Address(RVA = "0xBE18", Offset = "0xBE18", VA = "0xBE18")]
		public ToNextVisibleIsleWorldMovementInstant()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Type ---
		void CloudsFly_Movement_ToNextVisibleIsleWorldMovementInstant__get_Type
		               (undefined4 param1,undefined8 *param2,undefined4 param3,int param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  param1_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (param3,0);
		  local_8 = *(undefined4 *)(param2 + 1);
		  local_10 = *param2;
		  UnityEngine_Transform__get_position(param1_00,&local_10,0);
		  if (param4 != 0) {
		    (**(code **)((ulonglong)*(uint *)(param4 + 0xc) * 4))
		              (*(undefined4 *)(param4 + 0x20),*(undefined4 *)(param4 + 0x14));
		  }
		  return;
		}
		*/

}
