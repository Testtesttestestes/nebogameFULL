using System;
using System.Runtime.CompilerServices;
using Gameplay.MageSchool.Events;
using Gameplay.School.Controller;
using Gameplay.School.Model;
using Il2CppDummyDll;
using UI.Elements.Buildings;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Windows.Buildings.MageSchoolWindow
{
	// Token: 0x020002BC RID: 700
	[Token(Token = "0x20002BC")]
	public class SchoolWindow2 : ClosableBaseWindow<SchoolWindowArgs>
	{
		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06001074 RID: 4212 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000267")]
		public override string WindowId
		{
			[Token(Token = "0x6001074")]
			[Address(RVA = "0x6271", Offset = "0x6271", VA = "0x6271", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000103 RID: 259
		// (add) Token: 0x06001075 RID: 4213 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001076 RID: 4214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000103")]
		public event Action<uint> OnSelectSpell
		{
			[Token(Token = "0x6001075")]
			[Address(RVA = "0x6272", Offset = "0x6272", VA = "0x6272")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001076")]
			[Address(RVA = "0x6273", Offset = "0x6273", VA = "0x6273")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000104 RID: 260
		// (add) Token: 0x06001077 RID: 4215 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001078 RID: 4216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000104")]
		public event Action<uint> OnDeselectSpell
		{
			[Token(Token = "0x6001077")]
			[Address(RVA = "0x6274", Offset = "0x6274", VA = "0x6274")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001078")]
			[Address(RVA = "0x6275", Offset = "0x6275", VA = "0x6275")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06001079 RID: 4217 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000268")]
		public SpellList NeutralSpellsList
		{
			[Token(Token = "0x6001079")]
			[Address(RVA = "0x6276", Offset = "0x6276", VA = "0x6276")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x0600107A RID: 4218 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000269")]
		public SpellList SpecialSpellsList
		{
			[Token(Token = "0x600107A")]
			[Address(RVA = "0x6277", Offset = "0x6277", VA = "0x6277")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x0600107B RID: 4219 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700026A")]
		public BasicSpellInfo BasicSpellInfo
		{
			[Token(Token = "0x600107B")]
			[Address(RVA = "0x6278", Offset = "0x6278", VA = "0x6278")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x0600107C RID: 4220 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700026B")]
		public SpellUpgradeInfo SpellUpgradeInfo
		{
			[Token(Token = "0x600107C")]
			[Address(RVA = "0x6279", Offset = "0x6279", VA = "0x6279")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x0600107D RID: 4221 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700026C")]
		public Button SpellInfoButton
		{
			[Token(Token = "0x600107D")]
			[Address(RVA = "0x627A", Offset = "0x627A", VA = "0x627A")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600107E")]
		[Address(RVA = "0x627B", Offset = "0x627B", VA = "0x627B", Slot = "22")]
		protected override void OnShow(SchoolWindowArgs args)
		{
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600107F")]
		[Address(RVA = "0x627C", Offset = "0x627C", VA = "0x627C")]
		private void SetupMvc()
		{
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001080")]
		[Address(RVA = "0x627D", Offset = "0x627D", VA = "0x627D")]
		private void DestroyMvc()
		{
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001081")]
		[Address(RVA = "0x627E", Offset = "0x627E", VA = "0x627E")]
		private void OnNeutralSpellClick(SpellItemArgs spellItemArgs)
		{
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001082")]
		[Address(RVA = "0x627F", Offset = "0x627F", VA = "0x627F")]
		private void OnSpecialSpellClick(SpellItemArgs spellItemArgs)
		{
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001083")]
		[Address(RVA = "0x6280", Offset = "0x6280", VA = "0x6280")]
		private void OnDeselectSpellClick(SpellItemArgs spellItemArgs)
		{
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001084")]
		[Address(RVA = "0x6281", Offset = "0x6281", VA = "0x6281", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001085")]
		[Address(RVA = "0x6282", Offset = "0x6282", VA = "0x6282")]
		public SchoolWindow2()
		{
		}

		// Token: 0x04000874 RID: 2164
		[Token(Token = "0x4000874")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/MageSchool/MageSchoolWindow2";

		// Token: 0x04000875 RID: 2165
		[Token(Token = "0x4000875")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private SpellList _neutralSpellList;

		// Token: 0x04000876 RID: 2166
		[Token(Token = "0x4000876")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SpellList _specialSpellList;

		// Token: 0x04000877 RID: 2167
		[Token(Token = "0x4000877")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private BasicSpellInfo _basicSpellInfo;

		// Token: 0x04000878 RID: 2168
		[Token(Token = "0x4000878")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SpellUpgradeInfo _spellUpgradeInfo;

		// Token: 0x04000879 RID: 2169
		[Token(Token = "0x4000879")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Button _spellInfoButton;

		// Token: 0x0400087C RID: 2172
		[Token(Token = "0x400087C")]
		[FieldOffset(Offset = "0x58")]
		private bool _isMvcInitialized;

		// Token: 0x0400087D RID: 2173
		[Token(Token = "0x400087D")]
		[FieldOffset(Offset = "0x5C")]
		private SchoolEvents _events;

		// Token: 0x0400087E RID: 2174
		[Token(Token = "0x400087E")]
		[FieldOffset(Offset = "0x60")]
		private SchoolModel _model;

		// Token: 0x0400087F RID: 2175
		[Token(Token = "0x400087F")]
		[FieldOffset(Offset = "0x64")]
		private SchoolController _controller;

		// Token: 0x04000880 RID: 2176
		[Token(Token = "0x4000880")]
		[FieldOffset(Offset = "0x68")]
		private SchoolViewMediator2 _mediator;
	}
}
