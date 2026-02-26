using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000007 RID: 7
[Token(Token = "0x2000007")]
public class CodeConventions
{
	// Token: 0x14000001 RID: 1
	// (add) Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000001")]
	public event Action FooEvent
	{
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x555F", Offset = "0x555F", VA = "0x555F")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x5560", Offset = "0x5560", VA = "0x5560")]
		[CompilerGenerated]
		remove
		{
		}
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009C")]
	[Address(RVA = "0x5561", Offset = "0x5561", VA = "0x5561")]
	private void Foo()
	{
	}

	// Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009D")]
	[Address(RVA = "0x5562", Offset = "0x5562", VA = "0x5562")]
	protected void Bear()
	{
		/* --- GHIDRA: Bear ---
		void CodeConventions__Bear(undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a64863 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9806);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9800);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9802);
		    DAT_ram_00a64863 = '\x01';
		  }
		  if (param2 < 0) {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_9800,0);
		  }
		  else if (param2 != 0) {
		    puVar1 = &StringLiteral_9806;
		    iVar2 = *(int *)(OKG_Logs_Debug_TypeInfo + 0x74);
		    goto joined_r0x825943fb;
		  }
		  puVar1 = &StringLiteral_9802;
		  iVar2 = *(int *)(OKG_Logs_Debug_TypeInfo + 0x74);
		joined_r0x825943fb:
		  if (iVar2 == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(*puVar1,0);
		  return;
		}
		*/

	}

	// Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009E")]
	[Address(RVA = "0x5563", Offset = "0x5563", VA = "0x5563")]
	public void Foo(int x)
	{
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x0600009F RID: 159 RVA: 0x00002070 File Offset: 0x00000270
	// (set) Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000002")]
	public int FooBar
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x5564", Offset = "0x5564", VA = "0x5564")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x5565", Offset = "0x5565", VA = "0x5565")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x060000A1 RID: 161 RVA: 0x00002088 File Offset: 0x00000288
	// (set) Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000003")]
	private float CurrentFooValue
	{
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x5566", Offset = "0x5566", VA = "0x5566")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x5567", Offset = "0x5567", VA = "0x5567")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x5568", Offset = "0x5568", VA = "0x5568")]
	public CodeConventions()
	{
		/* --- GHIDRA: .ctor ---
		void CodeConventions___ctor(int param1,int param2,int param3,undefined4 param4)
		
		{
		  char cVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  uVar3 = *(undefined4 *)(param3 + 4);
		  *(int *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 8) = uVar3;
		  *(int *)(param1 + 0x10) = param2;
		  cVar1 = *(char *)(param3 + 0x2e);
		  *(int *)(param1 + 0x20) = param1;
		  iVar2 = func_ii_4538(param3);
		  if (iVar2 == 0) {
		    if (param2 == 0) {
		      uVar3 = Mono_Unity_CertHelper__AddCertificatesToNativeChain
		                        (0,s_Delegate_to_an_instance_method_c_ram_0005d205);
		      func_ii_1050(uVar3,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		    *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		  }
		  else if (cVar1 == '\0') {
		    *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__Player_ram_00004b60 + 0x50;
		  }
		  else {
		    *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		    *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		  }
		  *(char **)(param1 + 0x1c) = s___Scripting__UnityEngine__Player_ram_00004b60 + 0x51;
		  return;
		}
		*/

	}

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	private GameObject _fooField;

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	protected GameObject _barField;

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	public const float FOO = 4f;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	public const string BAR_NAME = "string_value";

	// Token: 0x04000011 RID: 17
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x14")]
	private int _foo;

	// Token: 0x04000012 RID: 18
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x18")]
	protected float _bar;

	// Token: 0x04000013 RID: 19
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x1C")]
	public string FooTitle;

	// Token: 0x02000008 RID: 8
	// (Invoke) Token: 0x060000A5 RID: 165
	[Token(Token = "0x2000008")]
	public delegate void Bar();

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_FooEvent ---
		void CodeConventions__add_FooEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a64862 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a64862 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x10,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
