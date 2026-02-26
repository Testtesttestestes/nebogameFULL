using System;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;

namespace Gameplay.World.Model
{
	// Token: 0x02000369 RID: 873
	[Token(Token = "0x2000369")]
	[NullableContext(1)]
	[Nullable(0)]
	public class IsleAnimationRequestVo : IEquatable<IsleAnimationRequestVo>
	{
		// Token: 0x0600141C RID: 5148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600141C")]
		[Address(RVA = "0x65F8", Offset = "0x65F8", VA = "0x65F8")]
		public IsleAnimationRequestVo(uint AnimationId, ulong OwnerId, uint LaunchesAtTime)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_World_Model_IsleAnimationRequestVo___ctor
		               (int param1,undefined4 *param2,undefined8 *param3,undefined4 *param4,
		               undefined4 param5)
		
		{
		  *param2 = *(undefined4 *)(param1 + 8);
		  *param3 = *(undefined8 *)(param1 + 0x10);
		  *param4 = *(undefined4 *)(param1 + 0x18);
		  return;
		}
		*/

		/* --- GHIDRA: <Clone>$ ---
		void Gameplay_World_Model_IsleAnimationRequestVo___Clone__(int param1,int param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1 + 8) = *(undefined4 *)(param2 + 8);
		  *(undefined8 *)(param1 + 0x10) = *(undefined8 *)(param2 + 0x10);
		  *(undefined4 *)(param1 + 0x18) = *(undefined4 *)(param2 + 0x18);
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_World_Model_IsleAnimationRequestVo___ctor
		               (int param1,undefined4 *param2,undefined8 *param3,undefined4 *param4,
		               undefined4 param5)
		
		{
		  *param2 = *(undefined4 *)(param1 + 8);
		  *param3 = *(undefined8 *)(param1 + 0x10);
		  *param4 = *(undefined4 *)(param1 + 0x18);
		  return;
		}
		*/

		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700033E")]
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[Token(Token = "0x600141D")]
			[Address(RVA = "0x65F9", Offset = "0x65F9", VA = "0x65F9", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x00004E18 File Offset: 0x00003018
		// (set) Token: 0x0600141F RID: 5151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700033F")]
		public uint AnimationId
		{
			[Token(Token = "0x600141E")]
			[Address(RVA = "0x65FA", Offset = "0x65FA", VA = "0x65FA")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600141F")]
			[Address(RVA = "0x65FB", Offset = "0x65FB", VA = "0x65FB")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06001420 RID: 5152 RVA: 0x00004E30 File Offset: 0x00003030
		// (set) Token: 0x06001421 RID: 5153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000340")]
		public ulong OwnerId
		{
			[Token(Token = "0x6001420")]
			[Address(RVA = "0x65FC", Offset = "0x65FC", VA = "0x65FC")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001421")]
			[Address(RVA = "0x65FD", Offset = "0x65FD", VA = "0x65FD")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06001422 RID: 5154 RVA: 0x00004E48 File Offset: 0x00003048
		// (set) Token: 0x06001423 RID: 5155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000341")]
		public uint LaunchesAtTime
		{
			[Token(Token = "0x6001422")]
			[Address(RVA = "0x65FE", Offset = "0x65FE", VA = "0x65FE")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001423")]
			[Address(RVA = "0x65FF", Offset = "0x65FF", VA = "0x65FF")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001424")]
		[Address(RVA = "0x6600", Offset = "0x6600", VA = "0x6600", Slot = "3")]
		[CompilerGenerated]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		undefined4
		Gameplay_World_Model_IsleAnimationRequestVo__ToString
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58c83 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_1259);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1256);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3125);
		    DAT_ram_00a58c83 = '\x01';
		  }
		  func_ii_2010(param2,StringLiteral_3125,0);
		  local_4 = *(undefined4 *)(param1 + 8);
		  uVar1 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  func_ii_2010(param2,uVar1,0);
		  func_ii_2010(param2,StringLiteral_1259,0);
		  local_10 = *(undefined8 *)(param1 + 0x10);
		  uVar1 = func_ii_8783(&local_10,0);
		  func_ii_2010(param2,uVar1,0);
		  func_ii_2010(param2,StringLiteral_1256,0);
		  local_4 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  func_ii_2010(param2,uVar1,0);
		  return 1;
		}
		*/

			return null;
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x00004E60 File Offset: 0x00003060
		[Token(Token = "0x6001425")]
		[Address(RVA = "0x6601", Offset = "0x6601", VA = "0x6601", Slot = "6")]
		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			return default(bool);
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x00004E78 File Offset: 0x00003078
		[Token(Token = "0x6001426")]
		[Address(RVA = "0x6602", Offset = "0x6602", VA = "0x6602")]
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator !=(IsleAnimationRequestVo left, IsleAnimationRequestVo right)
		{
			return default(bool);
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x00004E90 File Offset: 0x00003090
		[Token(Token = "0x6001427")]
		[Address(RVA = "0x6603", Offset = "0x6603", VA = "0x6603")]
		[NullableContext(2)]
		[CompilerGenerated]
		public static bool operator ==(IsleAnimationRequestVo left, IsleAnimationRequestVo right)
		{
			return default(bool);
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x00004EA8 File Offset: 0x000030A8
		[Token(Token = "0x6001428")]
		[Address(RVA = "0x6604", Offset = "0x6604", VA = "0x6604", Slot = "2")]
		[CompilerGenerated]
		public override int GetHashCode()
		{
		/* --- GHIDRA: GetHashCode ---
		undefined4
		Gameplay_World_Model_IsleAnimationRequestVo__GetHashCode(int *param1,int *param2,undefined4 param3)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  
		  piVar1 = (int *)0x0;
		  if (DAT_ram_00a58c85 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Model_IsleAnimationRequestVo_TypeInfo);
		    DAT_ram_00a58c85 = '\x01';
		  }
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(Gameplay_World_Model_IsleAnimationRequestVo_TypeInfo + 0xb8) <=
		         (uint)*(byte *)(*param2 + 0xb8)) &&
		       (piVar1 = param2,
		       *(int *)(*(int *)(*param2 + 100) +
		                (uint)*(byte *)(Gameplay_World_Model_IsleAnimationRequestVo_TypeInfo + 0xb8) * 4 +
		               -4) != Gameplay_World_Model_IsleAnimationRequestVo_TypeInfo)) {
		      piVar1 = (int *)0x0;
		    }
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		                    (param1,piVar1,*(undefined4 *)(*param1 + 0xfc));
		  return uVar2;
		}
		*/

			return 0;
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x00004EC0 File Offset: 0x000030C0
		[Token(Token = "0x6001429")]
		[Address(RVA = "0x6605", Offset = "0x6605", VA = "0x6605", Slot = "0")]
		[NullableContext(2)]
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
		/* --- GHIDRA: Equals ---
		int Gameplay_World_Model_IsleAnimationRequestVo__Equals(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58c87 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Model_IsleAnimationRequestVo_TypeInfo);
		    DAT_ram_00a58c87 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Gameplay_World_Model_IsleAnimationRequestVo_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = *(undefined4 *)(param1 + 8);
		  *(undefined8 *)(iVar1 + 0x10) = *(undefined8 *)(param1 + 0x10);
		  *(undefined4 *)(iVar1 + 0x18) = *(undefined4 *)(param1 + 0x18);
		  return iVar1;
		}
		*/

		/* --- GHIDRA: Equals ---
		int Gameplay_World_Model_IsleAnimationRequestVo__Equals(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58c87 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Model_IsleAnimationRequestVo_TypeInfo);
		    DAT_ram_00a58c87 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Gameplay_World_Model_IsleAnimationRequestVo_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = *(undefined4 *)(param1 + 8);
		  *(undefined8 *)(iVar1 + 0x10) = *(undefined8 *)(param1 + 0x10);
		  *(undefined4 *)(iVar1 + 0x18) = *(undefined4 *)(param1 + 0x18);
		  return iVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x00004ED8 File Offset: 0x000030D8
		[Token(Token = "0x600142A")]
		[Address(RVA = "0x6606", Offset = "0x6606", VA = "0x6606", Slot = "7")]
		[NullableContext(2)]
		[CompilerGenerated]
		public virtual bool Equals(IsleAnimationRequestVo other)
		{
			return default(bool);
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600142C")]
		[Address(RVA = "0x6608", Offset = "0x6608", VA = "0x6608")]
		[CompilerGenerated]
		protected IsleAnimationRequestVo(IsleAnimationRequestVo original)
		{
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600142D")]
		[Address(RVA = "0x6609", Offset = "0x6609", VA = "0x6609")]
		[CompilerGenerated]
		public void Deconstruct(out uint AnimationId, out ulong OwnerId, out uint LaunchesAtTime)
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_LaunchesAtTime ---
		undefined4
		Gameplay_World_Model_IsleAnimationRequestVo__set_LaunchesAtTime(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58c82 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9960);
		    Mono_Security_ASN1__get_Item(&StringLiteral_507);
		    DAT_ram_00a58c82 = '\x01';
		  }
		  param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		  func_ii_2101(param1_00,0);
		  func_ii_2010(param1_00,StringLiteral_9960,0);
		  func_ii_2010(param1_00,StringLiteral_507,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,param1_00,*(undefined4 *)(*param1 + 0xf4));
		  if (iVar1 != 0) {
		    func_ii_3135(param1_00,0x20,0);
		  }
		  func_ii_3135(param1_00,0x7d,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                    (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		  return uVar2;
		}
		*/


		/* --- GHIDRA: op_Equality ---
		int Gameplay_World_Model_IsleAnimationRequestVo__op_Equality(int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int *piVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  undefined8 uVar7;
		  
		  if (DAT_ram_00a58c84 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_EqualityComparer_ulong__get_Default__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_EqualityComparer_Type__get_Default__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_EqualityComparer_uint__get_Default__);
		    DAT_ram_00a58c84 = '\x01';
		  }
		  piVar1 = (int *)UnityEngine_UIElements_PopupField___c__DisplayClass27_0_object____ctor
		                            (Method_System_Collections_Generic_EqualityComparer_Type__get_Default__)
		  ;
		  uVar7 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))(param1,uVar7);
		  uVar7 = CONCAT44((int)((ulonglong)uVar7 >> 0x20),uVar2);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x108) * 4))
		                    (piVar1,uVar7,*(undefined4 *)(*piVar1 + 0x10c));
		  uVar2 = (undefined4)((ulonglong)uVar7 >> 0x20);
		  piVar1 = (int *)System_Collections_Generic_EqualityComparer_uint___System_Collections_IEqualityComparer_GetHashCode
		                            (Method_System_Collections_Generic_EqualityComparer_uint__get_Default__)
		  ;
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x108) * 4))
		                    (piVar1,CONCAT44(uVar2,param1[2]),*(undefined4 *)(*piVar1 + 0x10c));
		  piVar1 = (int *)System_Collections_Generic_EqualityComparer_ulong___System_Collections_IEqualityComparer_GetHashCode
		                            (Method_System_Collections_Generic_EqualityComparer_ulong__get_Default__
		                            );
		  uVar7 = *(undefined8 *)(param1 + 4);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x108) * 4))
		                    (piVar1,uVar7,*(undefined4 *)(*piVar1 + 0x10c));
		  uVar2 = (undefined4)((ulonglong)uVar7 >> 0x20);
		  piVar1 = (int *)System_Collections_Generic_EqualityComparer_uint___System_Collections_IEqualityComparer_GetHashCode
		                            (Method_System_Collections_Generic_EqualityComparer_uint__get_Default__)
		  ;
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x108) * 4))
		                    (piVar1,CONCAT44(uVar2,param1[6]),*(undefined4 *)(*piVar1 + 0x10c));
		  return iVar6 + (iVar5 + (iVar4 + iVar3 * -0x5aaaaad7) * -0x5aaaaad7) * -0x5aaaaad7;
		}
		*/

}
