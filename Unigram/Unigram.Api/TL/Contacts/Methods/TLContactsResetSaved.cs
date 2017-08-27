// <auto-generated/>
using System;

namespace Telegram.Api.TL.Contacts.Methods
{
	/// <summary>
	/// RCP method contacts.resetSaved.
	/// Returns <see cref="Telegram.Api.TL.TLBool"/>
	/// </summary>
	public partial class TLContactsResetSaved : TLObject
	{
		public TLContactsResetSaved() { }
		public TLContactsResetSaved(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ContactsResetSaved; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x879537F1);
		}
	}
}