using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.SCIM.WebHostSample.Resources
{
    public static class SampleTypeScheme
    {

        public static TypeScheme UserTypeSceme
        {
            get
            {
                TypeScheme userType = new TypeScheme();
                userType.Description = SampleConstants.UserAccount;
                userType.Identifier = SampleConstants.UserCore2Schema;
                userType.Name = SampleConstants.User;
                userType.AddAttribute(UserNameAttributeScheme);
                userType.AddAttribute(NameAttributeScheme);
                userType.AddAttribute(DisplayNameAttributeScheme);
                userType.AddAttribute(TittleAttributeScheme);
                userType.AddAttribute(UserTypeAttributeScheme);
                userType.AddAttribute(PreferredLanguageAttrbiuteScheme);
                userType.AddAttribute(LocaleAttributeScheme);
                userType.AddAttribute(ActiveAttributeScheme);
                userType.AddAttribute(EmailsAttributeScheme);
                userType.AddAttribute(PhoneNumbersAttributeScheme);
                userType.AddAttribute(AddressesAttributeScheme);

                return userType;
            }
        }

        public static TypeScheme EnterpriseUserTypeScheme
        {
            get
            {
                TypeScheme enterpriseType = new TypeScheme();
                enterpriseType.Description = SampleConstants.UserEnterprise;
                enterpriseType.Identifier = SampleConstants.UserEnterpriseSchema;
                enterpriseType.Name = SampleConstants.UserEnterpriseName;
                enterpriseType.AddAttribute(ManagerAttributeScheme);
                enterpriseType.AddAttribute(EmployeeNumberAttributeScheme);
                enterpriseType.AddAttribute(CostcenterAttributeScheme);
                enterpriseType.AddAttribute(OrganizationAttributeScheme);
                enterpriseType.AddAttribute(DivisionAttributeScheme);
                enterpriseType.AddAttribute(DepartmentAttributeScheme);

                return enterpriseType;
            }
        }

        public static TypeScheme GroupTypeSceme
        {
            get
            {
                TypeScheme groupType = new TypeScheme();
                groupType.Description = SampleConstants.Group;
                groupType.Identifier = SampleConstants.GroupSchema;
                groupType.Name = SampleConstants.Group;
                groupType.AddAttribute(GroupDisplayNameAttributeScheme);
                groupType.AddAttribute(MembersAttributeScheme);

                return groupType;
            }
        }

        public static AttributeScheme GroupDisplayNameAttributeScheme
        {
            get
            {
                AttributeScheme groupDisplayScheme = new AttributeScheme("displayName", AttributeDataType.@string, false);
                groupDisplayScheme.Description = SampleConstants.DescriptionGroupDisplayName;
                groupDisplayScheme.Required = true;
                groupDisplayScheme.Uniqueness = Uniqueness.server;

                return groupDisplayScheme;
            }
        }

        public static AttributeScheme ValueSubAttributeScheme
        {
            get
            {
                AttributeScheme valueScheme = new AttributeScheme("value", AttributeDataType.@string, false);
                valueScheme.Description = SampleConstants.DescriptionValue;
                valueScheme.Mutability = Mutability.immutable;
                return valueScheme;
            }
        }

        public static AttributeScheme RefSubAttributeScheme
        {
            get
            {
                AttributeScheme refScheme = new AttributeScheme("$ref", AttributeDataType.reference, false);
                refScheme.Description = SampleConstants.DescriptionRef;
                refScheme.Mutability = Mutability.immutable;
                refScheme.AddReferenceTypes(Types.User);
                return refScheme;
            }
        }

        public static AttributeScheme TypeSubAttributeScheme
        {
            get
            {
                AttributeScheme typeScheme = new AttributeScheme("type", AttributeDataType.@string, false);
                typeScheme.Description = SampleConstants.DescriptionType;
                typeScheme.Mutability = Mutability.immutable;
                typeScheme.AddCanonicalValues(Types.Group);
                typeScheme.AddCanonicalValues(Types.User);
                return typeScheme;
            }
        }

        public static AttributeScheme DisplaySubAttributeScheme
        {
            get
            {
                AttributeScheme typeScheme = new AttributeScheme("display", AttributeDataType.@string, false);
                typeScheme.Description = SampleConstants.DescriptionDisplay;
                return typeScheme;
            }
        }

        public static AttributeScheme Type2SubAttributeScheme
        {
            get
            {
                AttributeScheme typeScheme = new AttributeScheme("type", AttributeDataType.@string, false);
                typeScheme.Description = SampleConstants.DescriptionType;
                typeScheme.AddCanonicalValues("work");
                typeScheme.AddCanonicalValues("home");
                typeScheme.AddCanonicalValues("other");
                return typeScheme;
            }
        }

        public static AttributeScheme PrimarySubAttributeScheme
        {
            get
            {
                AttributeScheme typeScheme = new AttributeScheme("primary", AttributeDataType.boolean, false);
                typeScheme.Description = SampleConstants.DescriptionPrimary;
                return typeScheme;
            }
        }

        public static AttributeScheme MembersAttributeScheme
        {
            get
            {
                AttributeScheme membersScheme = new AttributeScheme("members", AttributeDataType.complex, true);
                membersScheme.Description = SampleConstants.DescriptionMemebers;
                membersScheme.AddSubAttribute(ValueSubAttributeScheme);
                membersScheme.AddSubAttribute(RefSubAttributeScheme);
                membersScheme.AddSubAttribute(TypeSubAttributeScheme);

                return membersScheme;
            }
        }

        public static AttributeScheme UserNameAttributeScheme
        {
            get
            {
                AttributeScheme userNameScheme = new AttributeScheme("userName", AttributeDataType.@string, false);
                userNameScheme.Description = SampleConstants.DescriptionUserName;
                userNameScheme.Required = true;
                userNameScheme.Uniqueness = Uniqueness.server;
                return userNameScheme;
            }
        }

        public static AttributeScheme FormattedNameAttributeScheme
        {
            get
            {

                AttributeScheme formattedNameScheme = new AttributeScheme("formatted", AttributeDataType.@string, false);
                formattedNameScheme.Description = SampleConstants.DescriptionFormattedName;
                return formattedNameScheme;

            }
        }

        public static AttributeScheme GivenNameAttributeScheme
        {
            get
            {

                AttributeScheme givenNameScheme = new AttributeScheme("givenName", AttributeDataType.@string, false);
                givenNameScheme.Description = SampleConstants.DescriptionGivenName;
                return givenNameScheme;

            }
        }

        public static AttributeScheme NameAttributeScheme
        {
            get
            {
                AttributeScheme nameScheme = new AttributeScheme("name", AttributeDataType.complex, false);
                nameScheme.Description = SampleConstants.DescriptionName;
                nameScheme.AddSubAttribute(FormattedNameAttributeScheme);
                nameScheme.AddSubAttribute(GivenNameAttributeScheme);
                return nameScheme;
            }
        }

        public static AttributeScheme DisplayNameAttributeScheme
        {
            get
            {
                AttributeScheme displayNameScheme = new AttributeScheme("displayName", AttributeDataType.@string, false);
                displayNameScheme.Description = SampleConstants.DescriptionDisplayName;
                return displayNameScheme;
            }
        }

        public static AttributeScheme TittleAttributeScheme
        {
            get
            {
                AttributeScheme titleScheme = new AttributeScheme("title", AttributeDataType.@string, false);
                titleScheme.Description = SampleConstants.DescriptionTitle;
                return titleScheme;
            }
        }

        public static AttributeScheme UserTypeAttributeScheme
        {
            get
            {
                AttributeScheme userTypeScheme = new AttributeScheme("userType", AttributeDataType.@string, false);
                userTypeScheme.Description = SampleConstants.DescriptionUserType;
                return userTypeScheme;
            }
        }

        public static AttributeScheme PreferredLanguageAttrbiuteScheme
        {
            get
            {
                AttributeScheme preferredLanguageScheme = new AttributeScheme("preferredLanguage", AttributeDataType.@string, false);
                preferredLanguageScheme.Description = SampleConstants.DescriptionPreferredLanguage;
                return preferredLanguageScheme;
            }
        }

        public static AttributeScheme LocaleAttributeScheme
        {
            get
            {
                AttributeScheme preferredLanguageScheme = new AttributeScheme("locale", AttributeDataType.@string, false);
                preferredLanguageScheme.Description = SampleConstants.DescriptionLocale;
                return preferredLanguageScheme;
            }
        }

        public static AttributeScheme ActiveAttributeScheme
        {
            get
            {
                AttributeScheme activeScheme = new AttributeScheme("active", AttributeDataType.boolean, false);
                activeScheme.Description = SampleConstants.DescriptionActive;
                return activeScheme;
            }
        }

        public static AttributeScheme EmailsAttributeScheme
        {
            get
            {
                AttributeScheme emailsScheme = new AttributeScheme("emails", AttributeDataType.complex, true);
                emailsScheme.Description = SampleConstants.DescriptionEmails;
                emailsScheme.AddSubAttribute(ValueSubAttributeScheme);
                emailsScheme.AddSubAttribute(DisplaySubAttributeScheme);
                emailsScheme.AddSubAttribute(Type2SubAttributeScheme);
                emailsScheme.AddSubAttribute(PrimarySubAttributeScheme);
                return emailsScheme;
            }
        }

        public static AttributeScheme PhoneNumbersAttributeScheme
        {
            get
            {
                AttributeScheme phoneNumbersScheme = new AttributeScheme("phoneNumbers", AttributeDataType.complex, true);
                phoneNumbersScheme.Description = SampleConstants.DescriptionPhoneNumbers;
                phoneNumbersScheme.AddSubAttribute(ValueSubAttributeScheme);
                phoneNumbersScheme.AddSubAttribute(DisplaySubAttributeScheme);
                phoneNumbersScheme.AddSubAttribute(Type2SubAttributeScheme);
                phoneNumbersScheme.AddSubAttribute(PrimarySubAttributeScheme);
                return phoneNumbersScheme;
            }
        }
        public static AttributeScheme FormattedAddressAttributeScheme
        {
            get
            {

                AttributeScheme formattedAddressScheme = new AttributeScheme("formatted", AttributeDataType.@string, false);
                formattedAddressScheme.Description = SampleConstants.DescriptionFormattedAddress;
                return formattedAddressScheme;

            }
        }
        public static AttributeScheme StreetAddressAttributeScheme
        {
            get
            {

                AttributeScheme streetAddressScheme = new AttributeScheme("streetAddress", AttributeDataType.@string, false);
                streetAddressScheme.Description = SampleConstants.DescriptionStreetAddress;
                return streetAddressScheme;

            }
        }
        public static AttributeScheme AddressesAttributeScheme
        {
            get
            {
                AttributeScheme addressesScheme = new AttributeScheme("addresses", AttributeDataType.complex, true);
                addressesScheme.Description = SampleConstants.DescriptionAddresses;
                addressesScheme.AddSubAttribute(FormattedAddressAttributeScheme);
                addressesScheme.AddSubAttribute(StreetAddressAttributeScheme);
                addressesScheme.AddSubAttribute(Type2SubAttributeScheme);
                return addressesScheme;
            }
        }

        public static AttributeScheme ManagerAttributeScheme
        {
            get
            {
                AttributeScheme managerScheme = new AttributeScheme("manager", AttributeDataType.complex, false);
                managerScheme.Description = SampleConstants.DescriptionManager;
                managerScheme.AddSubAttribute(ValueSubAttributeScheme);
                managerScheme.AddSubAttribute(RefSubAttributeScheme);
                managerScheme.AddSubAttribute(DisplayNameAttributeScheme);
                return managerScheme;
            }
        }

        public static AttributeScheme EmployeeNumberAttributeScheme
        {
            get
            {
                AttributeScheme employeeNumberScheme = new AttributeScheme("employeeNumber", AttributeDataType.@string, false);
                employeeNumberScheme.Description = SampleConstants.DescriptionEmployeeNumber;
                return employeeNumberScheme;
            }
        }

        public static AttributeScheme CostcenterAttributeScheme
        {
            get
            {
                AttributeScheme costCenterScheme = new AttributeScheme("costCenter", AttributeDataType.@string, false);
                costCenterScheme.Description = SampleConstants.DescriptionCostCenter;
                return costCenterScheme;
            }
        }

        public static AttributeScheme OrganizationAttributeScheme
        {
            get
            {
                AttributeScheme organizationScheme = new AttributeScheme("organization", AttributeDataType.@string, false);
                organizationScheme.Description = SampleConstants.DescriptionOrganization;
                return organizationScheme;
            }
        }

        public static AttributeScheme DivisionAttributeScheme
        {
            get
            {
                AttributeScheme divisionScheme = new AttributeScheme("division", AttributeDataType.@string, false);
                divisionScheme.Description = SampleConstants.DescriptionDivision;
                return divisionScheme;
            }
        }

        public static AttributeScheme DepartmentAttributeScheme
        {
            get
            {
                AttributeScheme departmentScheme = new AttributeScheme("department", AttributeDataType.@string, false);
                departmentScheme.Description = SampleConstants.Descriptiondepartment;
                return departmentScheme;
            }
        }
    }
}
