using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.AccountLinker.Model;
using Gameplay.Aprs.View;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.AccountLinker.View
{
	// Token: 0x02000DF4 RID: 3572
	[Token(Token = "0x2000DF4")]
	public class AccountLinkerUserView : MonoBehaviour
	{
		// Token: 0x06005731 RID: 22321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005731")]
		[Address(RVA = "0xA4AC", Offset = "0xA4AC", VA = "0xA4AC")]
		private void Awake()
		{
		}

		// Token: 0x06005732 RID: 22322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005732")]
		[Address(RVA = "0xA4AD", Offset = "0xA4AD", VA = "0xA4AD")]
		private void OnDestroy()
		{
		}

		// Token: 0x14000207 RID: 519
		// (add) Token: 0x06005733 RID: 22323 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005734 RID: 22324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000207")]
		public event EventHandler<LinkerUser> OnSelectEvent
		{
			[Token(Token = "0x6005733")]
			[Address(RVA = "0xA4AE", Offset = "0xA4AE", VA = "0xA4AE")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005734")]
			[Address(RVA = "0xA4AF", Offset = "0xA4AF", VA = "0xA4AF")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x06005735 RID: 22325 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005736 RID: 22326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011C5")]
		public LinkerUser User
		{
			[Token(Token = "0x6005735")]
			[Address(RVA = "0xA4B0", Offset = "0xA4B0", VA = "0xA4B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005736")]
			[Address(RVA = "0xA4B1", Offset = "0xA4B1", VA = "0xA4B1")]
			set
			{
			}
		}

		// Token: 0x06005737 RID: 22327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005737")]
		[Address(RVA = "0xA4B2", Offset = "0xA4B2", VA = "0xA4B2")]
		private void HandleUserChanged()
		{
		}

		// Token: 0x06005738 RID: 22328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005738")]
		[Address(RVA = "0xA4B3", Offset = "0xA4B3", VA = "0xA4B3")]
		private void HandleSkillsClick()
		{
		}

		// Token: 0x06005739 RID: 22329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005739")]
		[Address(RVA = "0xA4B4", Offset = "0xA4B4", VA = "0xA4B4")]
		public AccountLinkerUserView()
		{
		}

		// Token: 0x04002F32 RID: 12082
		[Token(Token = "0x4002F32")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<TextMeshProUGUI> _nickFields;

		// Token: 0x04002F33 RID: 12083
		[Token(Token = "0x4002F33")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _selectButton;

		// Token: 0x04002F34 RID: 12084
		[Token(Token = "0x4002F34")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UserNickCultLevelExpView _levelView;

		// Token: 0x04002F35 RID: 12085
		[Token(Token = "0x4002F35")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private AprView _aprView;

		// Token: 0x04002F36 RID: 12086
		[Token(Token = "0x4002F36")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _faqButton;

		// Token: 0x04002F37 RID: 12087
		[Token(Token = "0x4002F37")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private SkillsInfoView _skillsView;

		// Token: 0x04002F38 RID: 12088
		[Token(Token = "0x4002F38")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _contentContainer;

		// Token: 0x04002F39 RID: 12089
		[Token(Token = "0x4002F39")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Button _skillsCloseButton;

		// Token: 0x04002F3B RID: 12091
		[Token(Token = "0x4002F3B")]
		[FieldOffset(Offset = "0x34")]
		private LinkerUser _user;
	}
}
