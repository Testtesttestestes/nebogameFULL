using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;

namespace Core.Money
{
	// Token: 0x02000EB4 RID: 3764
	[Token(Token = "0x2000EB4")]
	public class Money : IEnumerator<Money>, IEnumerator, IDisposable, IEnumerable<Money>, IEnumerable, ICloneable, IEquatable<Money>
	{
		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x06005B8C RID: 23436 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170012A3")]
		public Money.MoneyType Type
		{
			[Token(Token = "0x6005B8C")]
			[Address(RVA = "0xA84D", Offset = "0xA84D", VA = "0xA84D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x06005B8D RID: 23437 RVA: 0x000104A0 File Offset: 0x0000E6A0
		[Token(Token = "0x170012A4")]
		public double Value
		{
			[Token(Token = "0x6005B8D")]
			[Address(RVA = "0xA84E", Offset = "0xA84E", VA = "0xA84E")]
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06005B8E RID: 23438 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B8E")]
		[Address(RVA = "0xA84F", Offset = "0xA84F", VA = "0xA84F")]
		public static explicit operator ResourceSet(Money money)
		{
			return null;
		}

		// Token: 0x06005B8F RID: 23439 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B8F")]
		[Address(RVA = "0xA850", Offset = "0xA850", VA = "0xA850")]
		public static Money FromResourceSet(ResourceSet resourceSet)
		{
			return null;
		}

		// Token: 0x06005B90 RID: 23440 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B90")]
		[Address(RVA = "0x1F14", Offset = "0x1F14", VA = "0x1F14")]
		public static Money FromResource(Money.MoneyType type, double value)
		{
			return null;
		}

		// Token: 0x06005B91 RID: 23441 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B91")]
		[Address(RVA = "0xA851", Offset = "0xA851", VA = "0xA851")]
		public static Money FromResources(IReadOnlyDictionary<Money.MoneyType, double> values)
		{
			return null;
		}

		// Token: 0x06005B92 RID: 23442 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B92")]
		[Address(RVA = "0xA852", Offset = "0xA852", VA = "0xA852")]
		public static Money FromMoney(IReadOnlyList<Money> content)
		{
			return null;
		}

		// Token: 0x06005B93 RID: 23443 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B93")]
		[Address(RVA = "0xA853", Offset = "0xA853", VA = "0xA853")]
		public static Money CreateEmpty()
		{
			return null;
		}

		// Token: 0x06005B94 RID: 23444 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B94")]
		[Address(RVA = "0xA854", Offset = "0xA854", VA = "0xA854")]
		public static Money operator +(Money a, Money b)
		{
			return null;
		}

		// Token: 0x06005B95 RID: 23445 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B95")]
		[Address(RVA = "0xA855", Offset = "0xA855", VA = "0xA855")]
		public static Money operator -(Money a, Money b)
		{
			return null;
		}

		// Token: 0x06005B96 RID: 23446 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B96")]
		[Address(RVA = "0xA856", Offset = "0xA856", VA = "0xA856")]
		public static Money operator *(Money a, double b)
		{
			return null;
		}

		// Token: 0x06005B97 RID: 23447 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B97")]
		[Address(RVA = "0x1B16", Offset = "0x1B16", VA = "0x1B16")]
		public Money CloneWithValue(Money.MoneyType type, double value)
		{
			return null;
		}

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x06005B98 RID: 23448 RVA: 0x000104B8 File Offset: 0x0000E6B8
		[Token(Token = "0x170012A5")]
		public bool IsEmpty
		{
			[Token(Token = "0x6005B98")]
			[Address(RVA = "0xA857", Offset = "0xA857", VA = "0xA857")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005B99 RID: 23449 RVA: 0x000104D0 File Offset: 0x0000E6D0
		[Token(Token = "0x6005B99")]
		[Address(RVA = "0xA858", Offset = "0xA858", VA = "0xA858")]
		public static bool operator !=(Money a, Money b)
		{
			return default(bool);
		}

		// Token: 0x06005B9A RID: 23450 RVA: 0x000104E8 File Offset: 0x0000E6E8
		[Token(Token = "0x6005B9A")]
		[Address(RVA = "0xA859", Offset = "0xA859", VA = "0xA859")]
		public static bool operator ==(Money a, Money b)
		{
			return default(bool);
		}

		// Token: 0x06005B9B RID: 23451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B9B")]
		[Address(RVA = "0xA85A", Offset = "0xA85A", VA = "0xA85A")]
		private Money(Money.MoneyType type, double value, [Optional] IEnumerable<Money> complexContent)
		{
		}

		// Token: 0x06005B9C RID: 23452 RVA: 0x00010500 File Offset: 0x0000E700
		[Token(Token = "0x6005B9C")]
		[Address(RVA = "0xA85B", Offset = "0xA85B", VA = "0xA85B", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06005B9D RID: 23453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B9D")]
		[Address(RVA = "0xA85C", Offset = "0xA85C", VA = "0xA85C", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x06005B9E RID: 23454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B9E")]
		[Address(RVA = "0xA85D", Offset = "0xA85D", VA = "0xA85D", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x06005B9F RID: 23455 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170012A6")]
		private object Current
		{
			[Token(Token = "0x6005B9F")]
			[Address(RVA = "0xA85E", Offset = "0xA85E", VA = "0xA85E", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x06005BA0 RID: 23456 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170012A7")]
		private Money Current
		{
			[Token(Token = "0x6005BA0")]
			[Address(RVA = "0xA85F", Offset = "0xA85F", VA = "0xA85F", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005BA1 RID: 23457 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005BA1")]
		[Address(RVA = "0xA860", Offset = "0xA860", VA = "0xA860", Slot = "10")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06005BA2 RID: 23458 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005BA2")]
		[Address(RVA = "0xA861", Offset = "0xA861", VA = "0xA861", Slot = "9")]
		public IEnumerator<Money> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06005BA3 RID: 23459 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005BA3")]
		[Address(RVA = "0xA862", Offset = "0xA862", VA = "0xA862", Slot = "11")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x06005BA4 RID: 23460 RVA: 0x00010518 File Offset: 0x0000E718
		[Token(Token = "0x6005BA4")]
		[Address(RVA = "0xA863", Offset = "0xA863", VA = "0xA863", Slot = "12")]
		public bool Equals(Money other)
		{
			return default(bool);
		}

		// Token: 0x06005BA5 RID: 23461 RVA: 0x00010530 File Offset: 0x0000E730
		[Token(Token = "0x6005BA5")]
		[Address(RVA = "0xA864", Offset = "0xA864", VA = "0xA864", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06005BA6 RID: 23462 RVA: 0x00010548 File Offset: 0x0000E748
		[Token(Token = "0x6005BA6")]
		[Address(RVA = "0xA865", Offset = "0xA865", VA = "0xA865", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005BA7 RID: 23463 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005BA7")]
		[Address(RVA = "0xA866", Offset = "0xA866", VA = "0xA866", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040031FB RID: 12795
		[Token(Token = "0x40031FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<Money> _complexContent;

		// Token: 0x040031FC RID: 12796
		[Token(Token = "0x40031FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int _counter;

		// Token: 0x040031FD RID: 12797
		[Token(Token = "0x40031FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Money _current;

		// Token: 0x040031FE RID: 12798
		[Token(Token = "0x40031FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Dictionary<Money.MoneyType, double> EmptyMoneyMap;

		// Token: 0x02000EB5 RID: 3765
		[Token(Token = "0x2000EB5")]
		public sealed class MoneyType
		{
			// Token: 0x06005BA9 RID: 23465 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6005BA9")]
			[Address(RVA = "0xA868", Offset = "0xA868", VA = "0xA868")]
			public static IEnumerable<Money.MoneyType> GetEnumerable()
			{
				return null;
			}

			// Token: 0x06005BAA RID: 23466 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005BAA")]
			[Address(RVA = "0xA869", Offset = "0xA869", VA = "0xA869")]
			private MoneyType(int value)
			{
			}

			// Token: 0x06005BAB RID: 23467 RVA: 0x00010560 File Offset: 0x0000E760
			[Token(Token = "0x6005BAB")]
			[Address(RVA = "0xA86A", Offset = "0xA86A", VA = "0xA86A")]
			public static implicit operator int(Money.MoneyType type)
			{
				return 0;
			}

			// Token: 0x06005BAC RID: 23468 RVA: 0x00010578 File Offset: 0x0000E778
			[Token(Token = "0x6005BAC")]
			[Address(RVA = "0x1C6F", Offset = "0x1C6F", VA = "0x1C6F")]
			public static implicit operator Resources(Money.MoneyType type)
			{
				return Resources.UnknownResource;
			}

			// Token: 0x06005BAD RID: 23469 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6005BAD")]
			[Address(RVA = "0x1B15", Offset = "0x1B15", VA = "0x1B15")]
			public static implicit operator Money.MoneyType(Resources resources)
			{
				return null;
			}

			// Token: 0x06005BAE RID: 23470 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6005BAE")]
			[Address(RVA = "0xA86B", Offset = "0xA86B", VA = "0xA86B", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x040031FF RID: 12799
			[Token(Token = "0x40031FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly Money.MoneyType Complex;

			// Token: 0x04003200 RID: 12800
			[Token(Token = "0x4003200")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static readonly Money.MoneyType Crystals;

			// Token: 0x04003201 RID: 12801
			[Token(Token = "0x4003201")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static readonly Money.MoneyType Diamonds;

			// Token: 0x04003202 RID: 12802
			[Token(Token = "0x4003202")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static readonly Money.MoneyType Energy;

			// Token: 0x04003203 RID: 12803
			[Token(Token = "0x4003203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly Money.MoneyType Onyxes;

			// Token: 0x04003204 RID: 12804
			[Token(Token = "0x4003204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public static readonly Money.MoneyType ColossusFragments;

			// Token: 0x04003205 RID: 12805
			[Token(Token = "0x4003205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static readonly Money.MoneyType ThemeDuelPoints;

			// Token: 0x04003206 RID: 12806
			[Token(Token = "0x4003206")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public static readonly Money.MoneyType PortalPoints;

			// Token: 0x04003207 RID: 12807
			[Token(Token = "0x4003207")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private readonly int _value;
		}
	}
}
