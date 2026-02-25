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
}
